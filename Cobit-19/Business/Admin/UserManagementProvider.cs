﻿using AutoMapper;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Security.Claims;

namespace Cobit_19.Business.Admin
{
    public class UserManagementProvider
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager; 
        private readonly AppDbContext _dbContext;
        private static readonly object _lock = new object();

        public UserManagementProvider(IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext? dbContext)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        public IList<UserDto> GetAllUsers()
        {
            var users = _userManager.Users.ToList();
            var userDtos = _mapper.Map<IList<UserDto>>(users);

            return userDtos;
        }

        public async Task<IList<UserDto>> GetAllAuditorsByAuditIDAsync(int id, string objectiveType)
        {
            ArrayList userList = new ArrayList();
            IList<UserDto> finalAuditorUserList = new List<UserDto>();

            var usersInAudit = _dbContext.AuditMembers
                .Where(am => am.AuditID == id)
                .Select(am => am.ApplicationUserID);

            foreach(var userID in usersInAudit)
            {
                var user = await GetUserDtoByIdAsync(userID);

                userList.Add(user);
            }

            foreach (var user in userList)
            {
                var currentUser = (UserDto)user;
                var userRole = await getUserRoleAsync(currentUser);

                if (objectiveType == "Management" && userRole == "Management Auditor")
                {
                    finalAuditorUserList.Add(currentUser);
                }

                if (objectiveType == "Governance" && userRole == "Governance Auditor")
                {
                    finalAuditorUserList.Add(currentUser);
                }
            }

            return finalAuditorUserList;
        }

        public async Task<IList<UserDto>> GetAdminUsersAsync()
        {
            var adminUsers = await _userManager.GetUsersInRoleAsync("Administrator");

            var adminUserDtos = _mapper.Map<IList<UserDto>>(adminUsers);

            return adminUserDtos;
        }

        public async Task<UserDto> GetUserDtoByIdAsync(string id)
        {

            var user = await _userManager.FindByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
            
        }

        public async Task<bool> CreateUserAsync(UserEditorDto userDto)
        {
            var user = _mapper.Map<ApplicationUser>(userDto);
            user.LockoutEnabled = false;
            user.EmailConfirmed = true;

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, userDto.Password);

            var result = await _userManager.CreateAsync(user);
            return result.Succeeded;
        }

        public async Task<bool> UpdateUserAsync(UserEditorDto userDto)
        {
            var user = _mapper.Map<ApplicationUser>(userDto);

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }
        public async Task<bool> DeleteUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            try
            {
                var result = await _userManager.DeleteAsync(user);
                return result.Succeeded;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<string> getUserRoleAsync(UserDto user)
        {
            var mappedUser = _mapper.Map<ApplicationUser>(user);

            var roles = await _userManager.GetRolesAsync(mappedUser);

            if (roles.Count == 1)
            {
                string userRole = roles[0];
                return userRole;
            }
            else
            {
                return null; //Can a user have more than one role? Note for later discussion.
            }
            
        }

        public async Task addUserToRoleAsync(string userName, string role)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, role);
            }
        }

        public List<string> getAllRoles()
        {
            var roles = _roleManager.Roles.Select(role => role.Name).ToList();

            return roles;
        }

        public async Task<string> getUserIDAsync(ClaimsPrincipal user)
        {
            var currentUser =  _userManager.GetUserAsync(user).Result;
            var userID = currentUser.Id;
            return userID;
        }

        public async Task<(string, string)> getUserRealNameAsync(ClaimsPrincipal user)
        {
            var currentUser = _userManager.GetUserAsync(user).Result;
            var firstName = currentUser.FirstName;
            var lastName = currentUser.LastName;

            return (firstName, lastName);
        }
    }
}
