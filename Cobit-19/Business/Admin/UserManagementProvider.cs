using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Business.Admin
{
    public class UserManagementProvider
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager; 

        public UserManagementProvider(IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IList<UserDto> GetAllUsers()
        {
            var users = _userManager.Users.ToList();
            var userDtos = _mapper.Map<IList<UserDto>>(users);

            return userDtos;
        }

        public async Task<IList<UserDto>> GetAdminUsersAsync()
        {
            var adminUsers = await _userManager.GetUsersInRoleAsync("Administrator");

            var adminUserDtos = _mapper.Map<IList<UserDto>>(adminUsers);

            return adminUserDtos;
        }

        public async Task<UserDto> GetUserByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<bool> CreateUserAsync(UserEditorDto userDto)
        {
            var user = _mapper.Map<ApplicationUser>(userDto);

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

            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }
    }
}
