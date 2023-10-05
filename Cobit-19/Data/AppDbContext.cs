using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Emit;
using Cobit_19.Shared.Enums;
using Cobit_19.Data.Models;

namespace Cobit_19.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FocusAreaModel> FocusAreas { get; set; }
        public DbSet<AuditModel> Audits { get; set; }
        public DbSet<DesignFactorModel> DesignFactors { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ObjectiveModel> Objectives { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<ObjectiveAuditModel> ObjectiveAudits { get; set; }
        public DbSet<ObjectiveAuditTemplateModel> ObjectiveAuditTemplates { get; set; }
        public DbSet<MapModel> Maps { get; set; }
        public DbSet<SubscriptionModel> Subscriptions { get; set; }
        public DbSet<AuditMemberModel> AuditMembers { get; set; }
        public DbSet<ObjectiveAuditMembersModel> ObjectiveAuditMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Table names

            builder.Entity<FocusAreaModel>().ToTable("FocusAreas");
            builder.Entity<AuditModel>().ToTable("Audits");
            builder.Entity<DesignFactorModel>().ToTable("DesignFactors");
            builder.Entity<QuestionModel>().ToTable("Questions");
            builder.Entity<ObjectiveModel>().ToTable("Objectives");
            builder.Entity<AnswerModel>().ToTable("Answers");
            builder.Entity<ObjectiveAuditModel>().ToTable("ObjectiveAudits");
            builder.Entity<ObjectiveAuditTemplateModel>().ToTable("ObjectiveAuditTemplates");
            builder.Entity<MapModel>().ToTable("Maps");
            builder.Entity<SubscriptionModel>().ToTable("Subscriptions");
            builder.Entity<AuditMemberModel>().ToTable("AuditMembers");
            builder.Entity<ObjectiveAuditMembersModel>().ToTable("ObjectiveAuditMembers");

            // Relationships

            //Answers
            builder.Entity<AnswerModel>()
                .HasKey(table => new
                {
                    table.AuditID,
                    table.QuestionID
                });

            builder.Entity<AnswerModel>()
               .HasOne(d => d.Audit)
               .WithMany(d => d.Answers)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AnswerModel>()
               .HasOne(d => d.Question)
               .WithMany(d => d.Answers)
               .OnDelete(DeleteBehavior.Restrict);

            //ObjectiveAuditTempaltes
            builder.Entity<ObjectiveAuditTemplateModel>()
                .HasKey(table => new
                {
                    table.ObjectiveID,
                    table.FocusAreaID
                });
            builder.Entity<ObjectiveAuditTemplateModel>()
               .HasOne(d => d.Objective)
               .WithMany(d => d.ObjectiveAuditTemplates)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ObjectiveAuditTemplateModel>()
               .HasOne(d => d.FocusArea)
               .WithMany(d => d.ObjectiveAuditTemplates)
               .OnDelete(DeleteBehavior.Cascade);

            //ObjectiveAuditMembers
            builder.Entity<ObjectiveAuditMembersModel>()
                .HasKey(table => new
                {
                    table.ApplicationUserID,
                    table.ObjectiveAuditID
                });

            //ObjectiveAudits
            builder.Entity<ObjectiveAuditModel>()
               .HasOne(d => d.Objective)
               .WithMany(d => d.ObjectiveAudits)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ObjectiveAuditModel>()
               .HasOne(d => d.Audit)
               .WithMany(d => d.ObjectiveAudits)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ObjectiveAuditModel>()
               .HasMany(d => d.ObjectiveAuditMembers)
               .WithOne(d => d.ObjectiveAudit)
               .OnDelete(DeleteBehavior.Cascade);

            //Audits
            builder.Entity<AuditModel>()
                .HasMany(d => d.ObjectiveAudits)
                .WithOne(d => d.Audit)
                .OnDelete(DeleteBehavior.Cascade);

            //Objectives
            builder.Entity<ObjectiveModel>()
                .HasMany(d => d.ObjectiveAudits)
                .WithOne(d => d.Objective)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ObjectiveModel>()
                .HasMany(d => d.ObjectiveAuditTemplates)
                .WithOne(d => d.Objective)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.Entity<ObjectiveModel>()
                .HasMany(d => d.Maps)
                .WithOne(d => d.Objective)
                .OnDelete(DeleteBehavior.Cascade);

            //Maps
            builder.Entity<MapModel>()
                .HasKey(table => new
                {
                    table.ObjectiveID,
                    table.QuestionID
                });

            //Questions
            builder.Entity<QuestionModel>()
                .HasMany(d => d.Maps)
                .WithOne(d => d.Question)
                .OnDelete(DeleteBehavior.Cascade);

            //ApplicationUsers
            builder.Entity<ApplicationUser>()
                .HasMany(d => d.Audits)
                .WithOne(d => d.ApplicationUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasMany(d => d.FocusAreas)
                .WithOne(d => d.ApplicationUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasMany(d => d.ObjectiveAuditMembers)
                .WithOne(d => d.ApplicationUser)
                .OnDelete(DeleteBehavior.Restrict);

            // Data seeding

            //Seeding roles to AspNetRoles table
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7", Name = "Head Auditor", NormalizedName = "HEAD AUDITOR".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "5e70cf29-1b64-4f58-85dd-07b3c46015a3", Name = "Governance Auditor", NormalizedName = " GOVERNANCE AUDITOR".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a", Name = "Management Auditor", NormalizedName = "MANAGEMENT AUDITOR".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295", Name = "Client", NormalizedName = "CLIENT".ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<ApplicationUser>();


            //Seeding the User to AspNetUsers table
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser //ADMIN USER
                {
                    FirstName = "Daniel",
                    LastName = "Coetzee",
                    Email = "test@gmail.com",
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", 
                    UserName = "test@gmail.com",
                    NormalizedUserName = "TEST@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                },
                new ApplicationUser //HEAD AUDITOR USER
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "john.smith@example.com",
                    Id = "fa567c12-5678-4321-bacd-87654321de1f", 
                    UserName = "john.smith@example.com",
                    NormalizedUserName = "JOHN.SMITH@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "RandomPa$$w0rd1"),
                },
                new ApplicationUser //GOVERNANCE AUDITOR USER
                {
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    Id = "9b1a0f34-8765-4321-dcba-ba09876543c2", 
                    UserName = "alice.johnson@example.com",
                    NormalizedUserName = "ALICE.JOHNSON@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "RandomPa$$w0rd2"),
                },
                new ApplicationUser //MANAGEMENT AUDITOR USER
                {
                    FirstName = "Emma",
                    LastName = "Davis",
                    Email = "emma.davis@example.com",
                    Id = "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                    UserName = "emma.davis@example.com",
                    NormalizedUserName = "EMMA.DAVIS@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "StrongP@ssw0rd"),
                },
                new ApplicationUser //CLIENT USER
                {
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = "michael.brown@example.com",
                    Id = "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                    UserName = "michael.brown@example.com",
                    NormalizedUserName = "MICHAEL.BROWN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "RandomPa$$w0rd3"),
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> //ADMIN
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },
                new IdentityUserRole<string> //HEAD AUDITOR
                {
                    RoleId = "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                    UserId = "fa567c12-5678-4321-bacd-87654321de1f"
                },
                new IdentityUserRole<string> //GOVERNANCE AUDITOR
                {
                    RoleId = "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                    UserId = "9b1a0f34-8765-4321-dcba-ba09876543c2"
                },
                new IdentityUserRole<string> //MANAGEMENT AUDITOR
                {
                    RoleId = "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                    UserId = "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d"
                },
                new IdentityUserRole<string> //CLIENT USER
                {
                    RoleId = "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                    UserId = "b2c3d4e5-f6a7-1234-5678-0987654321dc"
                }
            );

            builder.Entity<SubscriptionModel>().HasData(
                new SubscriptionModel { ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", FocusAreaID = 1 },
                new SubscriptionModel { ApplicationUserID = "fa567c12-5678-4321-bacd-87654321de1f", FocusAreaID = 1 },
                new SubscriptionModel { ApplicationUserID = "9b1a0f34-8765-4321-dcba-ba09876543c2", FocusAreaID = 1 },
                new SubscriptionModel { ApplicationUserID = "b2c3d4e5-f6a7-1234-5678-0987654321dc", FocusAreaID = 1 },
                new SubscriptionModel { ApplicationUserID = "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", FocusAreaID = 1 });

            builder.Entity<AuditMemberModel>().HasData(
                new AuditMemberModel { ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", AuditID = 2 },
                new AuditMemberModel { ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", AuditID = 3 },
                new AuditMemberModel { ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", AuditID = 4 },
                new AuditMemberModel { ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", AuditID = 5 },
                new AuditMemberModel { ApplicationUserID = "fa567c12-5678-4321-bacd-87654321de1f", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "9b1a0f34-8765-4321-dcba-ba09876543c2", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "b2c3d4e5-f6a7-1234-5678-0987654321dc", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", AuditID = 1 });

            builder.Entity<FocusAreaModel>().HasData(
                new FocusAreaModel { ID = 1, Name = "Cobit Core Model", Description = "General Core Model", DateCreated = DateTime.Parse("Jan 1, 2009"), ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            builder.Entity<DesignFactorModel>().HasData(
                new DesignFactorModel { ID = 1, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 1", Description = "Enterprise Strategy", Information = "Enterprises can have different strategies, expressed as one or more archetypes. \nEach of the four possible values for the enterprise strategy design factor must be rated between 1 (not important) and 5 (most important). \nIt is recommended to maintain a sufficient spread between values." },
                new DesignFactorModel { ID = 2, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 2", Description = "Enterprise Goals", Information = "Each of the thirteen enterprise goals must be rated between 1 (not important) and 5 (most important). Using the generic enterprise goals, determine the most important goals for the enterprise. It is advisable to select the top three to five most important enterprise goals; too many high-priority goals will lead to less meaningful goals cascade results. It is recommended to a maintain sufficient spread between values." },
                new DesignFactorModel { ID = 3, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 3", Description = "Risk Profile", Information = "The risk profile identifies the IT-related risk the enterprise is exposed to and indicates which areas of risk exceed the risk appetite. Each of the 19 risk categories contained in the risk profile design factor must be rated. Impact of the risk should it occur, as a value between 1 (not important) and 5 (critical)" },
                new DesignFactorModel { ID = 4, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 4", Description = "IT-Related Issues", Information = "A related method for an I&T risk assessment for the enterprise is to consider which I&T-related issues it currently faces, or, in other words, what I&T-related risk has materialized. It is recommended to maintain a sufficient spread between values." },
                new DesignFactorModel { ID = 5, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 5", Description = "Threat landscape", Information = "The threat landscape under which the enterprise operates can be classified into two categories. Normal - The enterprise is operating under what are considered normal threat levels. High - Due to its geopolitical situation, industry sector or particular profile, the enterprise is operating in a high-threat environment." },
                new DesignFactorModel { ID = 6, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 6", Description = "Compliance Requirements", Information = "The compliance requirements to which the enterprise is subject to, can be classified according to these categories. Low compliance requirements - The enterprise is subject to a minimal set of regular compliance requirements that are lower than average. Normal compliance requirements - The enterprise is subject to a set of regular compliance requirements that are common across different industries. High compliance requirements - The enterprise is subject to higher than average compliance requirements, most often related to the industry sector or geopolitical conditions" },
                new DesignFactorModel { ID = 7, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 7", Description = "Role of IT", Information = "The role of IT for the enterprise can be classified according to the categories: Support - IT is not crucial for the running and continuity of the business process and services, nor for their innovation. Factory - When IT fails, it immediately impacts the running and continuity of the business processes and services. However, IT is not seen as a driver for innovating business processes and services. Turnaround - IT is seen as a driver for innovating business processes and services. At this moment, however, IT is not a critical dependency for the current running and continuity of the business processes and services." },
                new DesignFactorModel { ID = 8, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 8", Description = "Sourcing model for IT", Information = "The sourcing model the enterprise adopts can be classified according to the categories: Outsourcing - The enterprise calls upon the services of a third party to provide IT services. Cloud - The enterprise maximizes the use of the cloud for providing IT services to its users. Insourced - The enterprise provides for their own IT staff and services." },
                new DesignFactorModel { ID = 9, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 9", Description = "IT implementation methods", Information = "The methods the enterprise adopts can be classified according to the categories: Agile - The enterprise uses Agile development working methods for its software development. DevOps - The enterprise uses DevOps working methods for software building, deployment and operations. Traditional - The enterprise uses a more classic approach towards software development (waterfall)                                  separates software development and operations." },
                new DesignFactorModel { ID = 10, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 10", Description = "The technology adoption strategy can be classified according to the categories: First mover - The enterprise generally adopts new technologies as early as possible and tries to gain a first-mover advantage. Follower - The enterprise typically waits for new technology to become mainstream and proven before adopting them. Slow adopter - The enterprise is very late in adopting new technologies." }
                //new DesignFactorModel { ID = 11, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 11", Description = "Enterprise Size" }
                );

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel { ID = 1, DesignFactorID = 1, BaseAnswer = 3, Question = "Growth/Acquisition" },
                new QuestionModel { ID = 2, DesignFactorID = 1, BaseAnswer = 3, Question = "Innovation/Differentiation" },
                new QuestionModel { ID = 3, DesignFactorID = 1, BaseAnswer = 3, Question = "Cost Leadership" },
                new QuestionModel { ID = 4, DesignFactorID = 1, BaseAnswer = 3, Question = "Client Service/Stability" },
                ////
                new QuestionModel { ID = 5, DesignFactorID = 2, BaseAnswer = 3, Question = "EG01—Portfolio of competitive products and services" },
                new QuestionModel { ID = 6, DesignFactorID = 2, BaseAnswer = 3, Question = "EG02—Managed business risk" },
                new QuestionModel { ID = 7, DesignFactorID = 2, BaseAnswer = 3, Question = "EG03—Compliance with external laws and regulations" },
                new QuestionModel { ID = 8, DesignFactorID = 2, BaseAnswer = 3, Question = "EG04—Quality of financial information" },
                new QuestionModel { ID = 9, DesignFactorID = 2, BaseAnswer = 3, Question = "EG05—Customer-oriented service culture" },
                new QuestionModel { ID = 10, DesignFactorID = 2, BaseAnswer = 3, Question = "EG06—Business-service continuity and availability" },
                new QuestionModel { ID = 11, DesignFactorID = 2, BaseAnswer = 3, Question = "EG07—Quality of management information" },
                new QuestionModel { ID = 12, DesignFactorID = 2, BaseAnswer = 3, Question = "EG08—Optimization of internal business process functionality" },
                new QuestionModel { ID = 13, DesignFactorID = 2, BaseAnswer = 3, Question = "EG09—Optimization of business process costs" },
                new QuestionModel { ID = 14, DesignFactorID = 2, BaseAnswer = 3, Question = "EG10—Staff skills, motivation and productivity" },
                new QuestionModel { ID = 15, DesignFactorID = 2, BaseAnswer = 3, Question = "EG11—Compliance with internal policies" },
                new QuestionModel { ID = 16, DesignFactorID = 2, BaseAnswer = 3, Question = "EG12—Managed digital transformation programs" },
                new QuestionModel { ID = 17, DesignFactorID = 2, BaseAnswer = 3, Question = "EG13—Product and business innovation" },
                ///
                new QuestionModel { ID = 18, DesignFactorID = 3, BaseAnswer = 3, Question = "IT investment decision-making, portfolio definition & maintenance" },
                new QuestionModel { ID = 19, DesignFactorID = 3, BaseAnswer = 3, Question = "Program & projects life cycle management" },
                new QuestionModel { ID = 20, DesignFactorID = 3, BaseAnswer = 3, Question = "IT cost & oversight" },
                new QuestionModel { ID = 21, DesignFactorID = 3, BaseAnswer = 3, Question = "IT expertise, skills & behaviour" },
                new QuestionModel { ID = 22, DesignFactorID = 3, BaseAnswer = 3, Question = "Enterprise/IT architecture" },
                new QuestionModel { ID = 23, DesignFactorID = 3, BaseAnswer = 3, Question = "IT operational infrastructure incidents" },
                new QuestionModel { ID = 24, DesignFactorID = 3, BaseAnswer = 3, Question = "Unauthorized actions" },
                new QuestionModel { ID = 25, DesignFactorID = 3, BaseAnswer = 3, Question = "Software adoption/usage problems" },
                new QuestionModel { ID = 26, DesignFactorID = 3, BaseAnswer = 3, Question = "Hardware incidents" },
                new QuestionModel { ID = 27, DesignFactorID = 3, BaseAnswer = 3, Question = "Software failures" },
                new QuestionModel { ID = 28, DesignFactorID = 3, BaseAnswer = 3, Question = "Logical attacks (hacking, malware, etc.)" },
                new QuestionModel { ID = 29, DesignFactorID = 3, BaseAnswer = 3, Question = "Third-party/supplier incidents" },
                new QuestionModel { ID = 30, DesignFactorID = 3, BaseAnswer = 3, Question = "Noncompliance" },
                new QuestionModel { ID = 31, DesignFactorID = 3, BaseAnswer = 3, Question = "Geopolitical Issues" },
                new QuestionModel { ID = 32, DesignFactorID = 3, BaseAnswer = 3, Question = "Industrial action" },
                new QuestionModel { ID = 33, DesignFactorID = 3, BaseAnswer = 3, Question = "Acts of nature" },
                new QuestionModel { ID = 34, DesignFactorID = 3, BaseAnswer = 3, Question = "Technology-based innovation" },
                new QuestionModel { ID = 35, DesignFactorID = 3, BaseAnswer = 3, Question = "Environmental" },
                new QuestionModel { ID = 36, DesignFactorID = 3, BaseAnswer = 3, Question = "Data & information management" },
                ///
                new QuestionModel { ID = 37, DesignFactorID = 4, BaseAnswer = 1, Question = "Frustration between different IT entities across the organization because of a perception of low contribution to business value" },
                new QuestionModel { ID = 38, DesignFactorID = 4, BaseAnswer = 1, Question = "Frustration between business departments (i.e., the IT customer) and the IT department because of failed initiatives or a perception of low contribution to business value" },
                new QuestionModel { ID = 39, DesignFactorID = 4, BaseAnswer = 1, Question = "Significant IT-related incidents, such as data loss, security breaches, project failure and application errors, linked to IT" },
                new QuestionModel { ID = 40, DesignFactorID = 4, BaseAnswer = 1, Question = "Service delivery problems by the IT outsourcer(s)" },
                new QuestionModel { ID = 41, DesignFactorID = 4, BaseAnswer = 1, Question = "Failures to meet IT-related regulatory or contractual requirements" },
                new QuestionModel { ID = 42, DesignFactorID = 4, BaseAnswer = 1, Question = "Regular audit findings or other assessment reports about poor IT performance or reported IT quality or service problems" },
                new QuestionModel { ID = 43, DesignFactorID = 4, BaseAnswer = 1, Question = "Substantial hidden and rogue IT spending, that is, IT spending by user departments outside the control of the normal IT investment decision mechanisms and approved budgets" },
                new QuestionModel { ID = 44, DesignFactorID = 4, BaseAnswer = 1, Question = "Duplications or overlaps between various initiatives, or other forms of wasted resources" },
                new QuestionModel { ID = 45, DesignFactorID = 4, BaseAnswer = 1, Question = "Insufficient IT resources, staff with inadequate skills or staff burnout/dissatisfaction" },
                new QuestionModel { ID = 46, DesignFactorID = 4, BaseAnswer = 1, Question = "IT-enabled changes or projects frequently failing to meet business needs and delivered late or over budget" },
                new QuestionModel { ID = 47, DesignFactorID = 4, BaseAnswer = 1, Question = "Reluctance by board members, executives or senior management to engage with IT, or a lack of committed business sponsorship for IT" },
                new QuestionModel { ID = 48, DesignFactorID = 4, BaseAnswer = 1, Question = "Complex IT operating model and/or unclear decision mechanisms for IT-related decisions" },
                new QuestionModel { ID = 49, DesignFactorID = 4, BaseAnswer = 1, Question = "Excessively high cost of IT" },
                new QuestionModel { ID = 50, DesignFactorID = 4, BaseAnswer = 2, Question = "Obstructed or failed implementation of new initiatives or innovations caused by the current IT architecture and systems" },
                new QuestionModel { ID = 51, DesignFactorID = 4, BaseAnswer = 2, Question = "Gap between business and technical knowledge, which leads to business users and information and/or technology specialists speaking different languages" },
                new QuestionModel { ID = 52, DesignFactorID = 4, BaseAnswer = 2, Question = "Regular issues with data quality and integration of data across various sources" },
                new QuestionModel { ID = 53, DesignFactorID = 4, BaseAnswer = 2, Question = "High level of end-user computing, creating (among other problems) a lack of oversight and quality control over the applications that are being developed and put in operation" },
                new QuestionModel { ID = 54, DesignFactorID = 4, BaseAnswer = 2, Question = "Business departments implementing their own information solutions with little or no involvement of the enterprise IT department (related to end-user computing, which often stems from dissatisfaction with IT solutions and services)" },
                new QuestionModel { ID = 55, DesignFactorID = 4, BaseAnswer = 2, Question = "Ignorance of and/or noncompliance with privacy regulations" },
                new QuestionModel { ID = 56, DesignFactorID = 4, BaseAnswer = 2, Question = "Inability to exploit new technologies or innovate using I&T" },
                ////
                new QuestionModel { ID = 57, DesignFactorID = 5, BaseAnswer = 33, Question = "High" },
                new QuestionModel { ID = 58, DesignFactorID = 5, BaseAnswer = 67, Question = "Normal" },
                ///
                new QuestionModel { ID = 59, DesignFactorID = 6, BaseAnswer = 0, Question = "High compliance requirements" },
                new QuestionModel { ID = 60, DesignFactorID = 6, BaseAnswer = 100, Question = "Normal compliance requirements" },
                new QuestionModel { ID = 61, DesignFactorID = 6, BaseAnswer = 0, Question = "Low compliance requirements" },
                ///
                new QuestionModel { ID = 62, DesignFactorID = 7, BaseAnswer = 3, Question = "Support" },
                new QuestionModel { ID = 63, DesignFactorID = 7, BaseAnswer = 3, Question = "Factory" },
                new QuestionModel { ID = 64, DesignFactorID = 7, BaseAnswer = 3, Question = "Turnaround" },
                new QuestionModel { ID = 65, DesignFactorID = 7, BaseAnswer = 3, Question = "Strategic" },
                ///
                new QuestionModel { ID = 66, DesignFactorID = 8, BaseAnswer = 33, Question = "Outsourcing" },
                new QuestionModel { ID = 67, DesignFactorID = 8, BaseAnswer = 33, Question = "Cloud" },
                new QuestionModel { ID = 68, DesignFactorID = 8, BaseAnswer = 33, Question = "Insourced" },
                ///
                new QuestionModel { ID = 69, DesignFactorID = 9, BaseAnswer = 15, Question = "Agile" },
                new QuestionModel { ID = 70, DesignFactorID = 9, BaseAnswer = 10, Question = "DevOps" },
                new QuestionModel { ID = 71, DesignFactorID = 9, BaseAnswer = 75, Question = "Traditional" },
                ///
                new QuestionModel { ID = 72, DesignFactorID = 10, BaseAnswer = 15, Question = "First mover", },
                new QuestionModel { ID = 73, DesignFactorID = 10, BaseAnswer = 70, Question = "Follower" },
                new QuestionModel { ID = 74, DesignFactorID = 10, BaseAnswer = 15, Question = "Slow adopter" }
                );

            builder.Entity<AuditModel>().HasData(
                new AuditModel { ID = 1, FocusAreaID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", Name = "Audit 1", DateCreated = DateTime.Parse("Jan 1, 2009"), Status = AuditStatus.InProgress },
                new AuditModel { ID = 2, FocusAreaID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", Name = "Audit 2", DateCreated = DateTime.Parse("Jan 2, 2009"), Status = AuditStatus.InProgress },
                new AuditModel { ID = 3, FocusAreaID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", Name = "Audit 3", DateCreated = DateTime.Parse("Jan 3, 2009"), Status = AuditStatus.InProgress },
                new AuditModel { ID = 4, FocusAreaID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", Name = "Audit 4", DateCreated = DateTime.Parse("Jan 4, 2009"), Status = AuditStatus.InProgress },
                new AuditModel { ID = 5, FocusAreaID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", Name = "Audit 5", DateCreated = DateTime.Parse("Jan 5, 2009"), Status = AuditStatus.InProgress }
                );
            builder.Entity<AnswerModel>().HasData(
                new AnswerModel { AuditID = 1, QuestionID = 1, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 2, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 3, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 4, Answer = 2, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 5, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 6, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 7, Answer = 5, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 8, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 9, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 10, Answer = 5, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 11, Answer = 2, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 12, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 13, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 14, Answer = 4, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 15, Answer = 4, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 16, Answer = 2, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 17, Answer = 2, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 18, Answer = 4, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 19, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 20, Answer = 2, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 21, Answer = 4, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 22, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 23, Answer = 5, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 24, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 25, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 26, Answer = 1, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 27, Answer = 4, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 28, Answer = 4, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 29, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 30, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 31, Answer = 1, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 32, Answer = 4, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 33, Answer = 5, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 34, Answer = 5, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 35, Answer = 3, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 36, Answer = 4, AnswerRange = 5, Odds = 2 },
                new AnswerModel { AuditID = 1, QuestionID = 37, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 38, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 39, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 40, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 41, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 42, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 43, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 44, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 45, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 46, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 47, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 48, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 49, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 50, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 51, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 52, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 53, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 54, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 55, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 56, Answer = 1, AnswerRange = 3 },
                new AnswerModel { AuditID = 1, QuestionID = 57, Answer = 36, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 58, Answer = 64, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 59, Answer = 5, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 60, Answer = 95, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 61, Answer = 0, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 62, Answer = 4, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 63, Answer = 3, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 64, Answer = 2, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 65, Answer = 5, AnswerRange = 5 },
                new AnswerModel { AuditID = 1, QuestionID = 66, Answer = 20, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 67, Answer = 15, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 68, Answer = 65, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 69, Answer = 20, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 70, Answer = 34, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 71, Answer = 46, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 72, Answer = 40, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 73, Answer = 33, AnswerRange = 100 },
                new AnswerModel { AuditID = 1, QuestionID = 74, Answer = 27, AnswerRange = 100 }
                );
            builder.Entity<ObjectiveModel>().HasData(
                //Evaluate, Direct and Monitor (EDM) 
                new ObjectiveModel { ID = 1, Name = "EDM01", Code = "EDM01", Description = "Ensure Governance Framework Setting and Maintenance" },
                new ObjectiveModel { ID = 2, Name = "EDM02", Code = "EDM02", Description = "Ensure Benefits Delivery" },
                new ObjectiveModel { ID = 3, Name = "EDM03", Code = "EDM03", Description = "Ensure Risk Optimisation" },
                new ObjectiveModel { ID = 4, Name = "EDM04", Code = "EDM04", Description = "Ensure Resource Optimisation" },
                new ObjectiveModel { ID = 5, Name = "EDM05", Code = "EDM05", Description = "Ensure Stakeholder Engagement" },

                //Align, Plan and Organize (APO)
                new ObjectiveModel { ID = 6, Name = "APO01", Code = "APO01", Description = "Manage the IT Management Framework" },
                new ObjectiveModel { ID = 7, Name = "APO02", Code = "APO02", Description = "Manage Strategy" },
                new ObjectiveModel { ID = 8, Name = "APO03", Code = "APO03", Description = "Manage Enterprise Architecture" },
                new ObjectiveModel { ID = 9, Name = "APO04", Code = "APO04", Description = "Manage Innovation" },
                new ObjectiveModel { ID = 10, Name = "APO05", Code = "APO05", Description = "Manage Portfolio" },
                new ObjectiveModel { ID = 11, Name = "APO06", Code = "APO06", Description = "Manage Budget and Costs" },
                new ObjectiveModel { ID = 12, Name = "APO07", Code = "APO07", Description = "Manage Human Resources" },
                new ObjectiveModel { ID = 13, Name = "APO08", Code = "APO08", Description = "Manage Relationships" },
                new ObjectiveModel { ID = 14, Name = "APO09", Code = "APO09", Description = "Manage Service Agreements" },
                new ObjectiveModel { ID = 15, Name = "APO010", Code = "APO010", Description = "Manage Vendors" },
                new ObjectiveModel { ID = 16, Name = "APO011", Code = "APO011", Description = "Manage Quality" },
                new ObjectiveModel { ID = 17, Name = "APO012", Code = "APO012", Description = "Manage Risk" },
                new ObjectiveModel { ID = 18, Name = "APO013", Code = "APO013", Description = "Manage Security" },
                new ObjectiveModel { ID = 19, Name = "APO014", Code = "APO014", Description = "Manage Data" },

                //Build, Acquire and Implement (BAI)
                new ObjectiveModel { ID = 20, Name = "BAI01", Code = "BAI12", Description = "Manage Programs" },
                new ObjectiveModel { ID = 21, Name = "BAI02", Code = "BAI02", Description = "Manage Requirements Definition" },
                new ObjectiveModel { ID = 22, Name = "BAI03", Code = "BAI03", Description = "Manage Solutions Identification and Build" },
                new ObjectiveModel { ID = 23, Name = "BAI04", Code = "BAI04", Description = "Manage Availability and Capacity" },
                new ObjectiveModel { ID = 24, Name = "BAI05", Code = "BAI05", Description = "Manage Organizational Change" },
                new ObjectiveModel { ID = 25, Name = "BAI06", Code = "BAI06", Description = "Manage IT Changes" },
                new ObjectiveModel { ID = 26, Name = "BAI07", Code = "BAI07", Description = "Manage IT Change Acceptance and Transitioning" },
                new ObjectiveModel { ID = 27, Name = "BAI08", Code = "BAI08", Description = "Manage Knowledge" },
                new ObjectiveModel { ID = 28, Name = "BAI09", Code = "BAI09", Description = "Manage Assets" },
                new ObjectiveModel { ID = 29, Name = "BAI10", Code = "BAI010", Description = "Manage Configuration" },
                new ObjectiveModel { ID = 30, Name = "BAI11", Code = "BAI011", Description = "Manage Projects" },

                //Deliver, Service and Support (DSS)
                new ObjectiveModel { ID = 31, Name = "DSS01", Code = "DSS01", Description = "Manage Operations" },
                new ObjectiveModel { ID = 32, Name = "DSS02", Code = "DSS02", Description = "Manage Service Requests and Incidents" },
                new ObjectiveModel { ID = 33, Name = "DSS03", Code = "DSS03", Description = "Manage Problems" },
                new ObjectiveModel { ID = 34, Name = "DSS04", Code = "DSS04", Description = "Manage Continuity" },
                new ObjectiveModel { ID = 35, Name = "DSS05", Code = "DSS05", Description = "Manage Security Services" },
                new ObjectiveModel { ID = 36, Name = "DSS06", Code = "DSS06", Description = "Manage Business Process Controls" },

                //Monitor, Evaluate and Assess (MEA)
                new ObjectiveModel { ID = 37, Name = "MEA01", Code = "MEA01", Description = "Manage Perfomance and Comformance Monitoring" },
                new ObjectiveModel { ID = 38, Name = "MEA02", Code = "MEA02", Description = "Manage System of Internal Control" },
                new ObjectiveModel { ID = 39, Name = "MEA03", Code = "MEA03", Description = "Manage Compliance With External Requirement" },
                new ObjectiveModel { ID = 40, Name = "MEA04", Code = "MEA04", Description = "Manage Assurance" }
                );

            builder.Entity<ObjectiveAuditModel>().HasData(

                //Audit ID 2                      
                new ObjectiveAuditModel { ID = 41, AuditID = 2, ObjectiveID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 42, AuditID = 2, ObjectiveID = 2, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 43, AuditID = 2, ObjectiveID = 3, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                                                  
                //AuObjectiveAuditModel           
                new ObjectiveAuditModel { ID = 44, AuditID = 3, ObjectiveID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 45, AuditID = 3, ObjectiveID = 2, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 46, AuditID = 3, ObjectiveID = 3, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                                       
                //AuObjectiveAuditModel
                new ObjectiveAuditModel { ID = 47, AuditID = 4, ObjectiveID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 48, AuditID = 4, ObjectiveID = 2, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 49, AuditID = 4, ObjectiveID = 3, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                                                   
                //auObjectiveAuditModel            
                new ObjectiveAuditModel { ID = 50, AuditID = 5, ObjectiveID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 51, AuditID = 5, ObjectiveID = 2, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new ObjectiveAuditModel { ID = 52, AuditID = 5, ObjectiveID = 3, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                );

            /// Mapping 4 Questions and 40 Objectives with their weights for design factor 1
            // Define the weights as a 2D array
            float[,] weights1 = new float[,]
            {
                { 1.0f, 1.0f, 1.5f, 1.5f },    // EDM01
                { 1.5f, 1.0f, 2.0f, 3.5f },    // EDM02
                { 1.0f, 1.0f, 1.0f, 2.0f },    // EDM03
                { 1.5f, 1.0f, 4.0f, 1.0f },    // EDM04
                { 1.5f, 1.5f, 1.0f, 2.0f },    // EDM05
                { 1.0f, 1.0f, 1.0f, 1.0f },    // APO01
                { 3.5f, 3.5f, 1.5f, 1.0f },    // APO02
                { 4.0f, 2.0f, 1.0f, 1.0f },    // APO03
                { 1.0f, 4.0f, 1.0f, 1.0f },    // APO04
                { 3.5f, 4.0f, 2.5f, 1.0f },    // APO05
                { 1.5f, 1.0f, 4.0f, 1.0f },    // APO06
                { 2.0f, 1.0f, 1.0f, 1.0f },    // APO07
                { 1.0f, 1.5f, 1.0f, 3.5f },    // APO08
                { 1.0f, 1.0f, 1.5f, 4.0f },    // APO09
                { 1.0f, 1.0f, 3.5f, 1.5f },    // APO10
                { 1.0f, 1.0f, 1.0f, 4.0f },    // APO11
                { 1.0f, 1.5f, 1.0f, 2.5f },    // APO12
                { 1.0f, 1.0f, 1.0f, 2.5f },    // APO13
                { 1.0f, 1.0f, 1.0f, 1.0f },    // APO14
                { 4.0f, 2.0f, 1.5f, 1.5f },    // BAI01
                { 1.0f, 1.0f, 1.5f, 1.0f },    // BAI02
                { 1.0f, 1.0f, 1.5f, 1.0f },    // BAI03
                { 1.0f, 1.0f, 1.0f, 3.0f },    // BAI04
                { 4.0f, 2.0f, 1.0f, 1.5f },    // BAI05
                { 2.0f, 2.0f, 1.0f, 1.5f },    // BAI06
                { 1.5f, 2.0f, 1.0f, 1.5f },    // BAI07
                { 1.0f, 3.5f, 1.0f, 1.0f },    // BAI08
                { 1.0f, 1.0f, 1.0f, 1.0f },    // BAI09
                { 1.0f, 1.0f, 1.0f, 1.0f },    // BAI10
                { 3.5f, 3.0f, 1.5f, 1.0f },    // BAI11
                { 1.0f, 1.0f, 1.0f, 1.5f },    // DSS01
                { 1.0f, 1.0f, 1.0f, 4.0f },    // DSS02
                { 1.0f, 1.0f, 1.0f, 3.0f },    // DSS03
                { 1.0f, 1.0f, 1.0f, 4.0f },    // DSS04
                { 1.0f, 1.0f, 1.0f, 2.5f },    // DSS05
                { 1.0f, 1.0f, 1.0f, 1.5f },    // DSS06
                { 1.0f, 1.0f, 1.0f, 1.0f },    // MEA01
                { 1.0f, 1.0f, 1.0f, 1.0f },    // MEA02
                { 1.0f, 1.0f, 1.0f, 1.0f },    // MEA03
                { 1.0f, 1.0f, 1.0f, 1.0f }     // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    {
                        float dsweight1 = weights1[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { QuestionID = j + 1, ObjectiveID = i + 1, Weight = dsweight1 }
                        );
                    };
                }
            }

            /// Mapping 12 Questions and 40 Objectives with their weights for design factor 2
            // Define the weights as a 2D array
            float[,] weights2 = new float[,]
            {
                { 4.0f,  4.0f,  4.0f,  0.0f,  4.0f,  1.0f,  0.0f,  3.0f,  2.0f,  1.0f,  3.0f,  6.0f,  1.0f },
                { 10.0f, 0.0f,  0.0f,  0.0f,  6.0f,  1.0f,  0.0f,  5.0f,  2.0f,  1.0f,  0.0f,  9.0f,  4.0f },
                { 0.0f,  8.0f,  4.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  0.0f,  0.0f,  3.0f,  0.0f,  0.0f },
                { 11.0f, 0.0f,  0.0f,  0.0f,  7.0f,  1.0f,  0.0f,  6.0f,  3.0f,  1.0f,  0.0f,  10.0f, 4.0f },
                { 0.0f,  1.0f,  2.0f,  6.0f,  0.0f,  0.0f,  6.0f,  0.0f,  4.0f,  0.0f,  2.0f,  0.0f,  0.0f },
                { 8.0f,  6.0f,  6.0f,  2.0f,  6.0f,  4.0f,  2.0f,  5.0f,  4.0f,  1.0f,  5.0f,  9.0f,  2.0f },
                { 11.0f, 0.0f,  0.0f,  0.0f,  8.0f,  1.0f,  0.0f,  5.0f,  1.0f,  4.0f,  0.0f,  9.0f,  5.0f },
                { 11.0f, 1.0f,  0.0f,  0.0f,  8.0f,  3.0f,  0.0f,  6.0f,  1.0f,  2.0f,  0.0f,  9.0f,  4.0f },
                { 11.0f, 0.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  4.0f,  1.0f,  3.0f,  0.0f,  8.0f,  7.0f },
                { 12.0f, 0.0f,  0.0f,  0.0f,  8.0f,  2.0f,  0.0f,  7.0f,  3.0f,  1.0f,  0.0f,  11.0f, 3.0f },
                { 5.0f,  0.0f,  0.0f,  6.0f,  3.0f,  0.0f,  6.0f,  3.0f,  8.0f,  0.0f,  0.0f,  6.0f,  2.0f },
                { 9.0f,  0.0f,  0.0f,  0.0f,  5.0f,  1.0f,  0.0f,  3.0f,  2.0f,  4.0f,  0.0f,  7.0f,  5.0f },
                { 17.0f, 0.0f,  0.0f,  0.0f,  10.0f, 2.0f,  0.0f,  7.0f,  2.0f,  5.0f,  0.0f,  12.0f, 8.0f },
                { 6.0f,  0.0f,  0.0f,  0.0f,  4.0f,  2.0f,  0.0f,  3.0f,  0.0f,  1.0f,  0.0f,  4.0f,  1.0f },
                { 8.0f,  0.0f,  0.0f,  0.0f,  4.0f,  2.0f,  0.0f,  4.0f,  1.0f,  0.0f,  0.0f,  5.0f,  2.0f },
                { 7.0f,  0.0f,  0.0f,  6.0f,  4.0f,  1.0f,  6.0f,  4.0f,  7.0f,  0.0f,  0.0f,  7.0f,  2.0f },
                { 0.0f,  6.0f,  0.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f },
                { 0.0f,  5.0f,  2.0f,  0.0f,  0.0f,  5.0f,  0.0f,  0.0f,  0.0f,  0.0f,  1.0f,  0.0f,  0.0f },
                { 0.0f,  4.0f,  2.0f,  6.0f,  0.0f,  3.0f,  6.0f,  0.0f,  4.0f,  0.0f,  1.0f,  0.0f,  0.0f },
                { 10.0f, 0.0f,  0.0f,  0.0f,  7.0f,  0.0f,  0.0f,  6.0f,  4.0f,  1.0f,  0.0f,  11.0f, 4.0f },
                { 15.0f, 0.0f,  0.0f,  0.0f,  10.0f, 2.0f,  0.0f,  8.0f,  3.0f,  3.0f,  0.0f,  12.0f, 5.0f },
                { 15.0f, 0.0f,  0.0f,  0.0f,  9.0f,  2.0f,  0.0f,  8.0f,  3.0f,  1.0f,  0.0f,  12.0f, 5.0f },
                { 6.0f,  1.0f,  0.0f,  0.0f,  3.0f,  4.0f,  0.0f,  3.0f,  1.0f,  0.0f,  0.0f,  4.0f,  1.0f },
                { 14.0f, 0.0f,  0.0f,  0.0f,  11.0f, 1.0f,  0.0f,  8.0f,  4.0f,  4.0f,  0.0f,  14.0f, 5.0f },
                { 8.0f,  2.0f,  0.0f,  0.0f,  5.0f,  2.0f,  0.0f,  4.0f,  0.0f,  1.0f,  0.0f,  5.0f,  3.0f },
                { 6.0f,  2.0f,  0.0f,  0.0f,  3.0f,  1.0f,  0.0f,  3.0f,  1.0f,  0.0f,  0.0f,  4.0f,  3.0f },
                { 11.0f, 0.0f,  0.0f,  0.0f,  7.0f,  0.0f,  0.0f,  4.0f,  2.0f,  5.0f,  0.0f,  9.0f,  7.0f },
                { 0.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  6.0f,  0.0f,  5.0f,  0.0f,  0.0f,  0.0f,  0.0f },
                { 2.0f,  0.0f,  0.0f,  0.0f,  1.0f,  1.0f,  0.0f,  1.0f,  0.0f,  0.0f,  0.0f,  1.0f,  0.0f },
                { 12.0f, 0.0f,  0.0f,  0.0f,  7.0f,  1.0f,  0.0f,  7.0f,  4.0f,  0.0f,  0.0f,  11.0f, 4.0f },
                { 6.0f,  0.0f,  0.0f,  0.0f,  4.0f,  2.0f,  0.0f,  3.0f,  0.0f,  1.0f,  0.0f,  4.0f,  1.0f },
                { 4.0f,  3.0f,  0.0f,  0.0f,  2.0f,  5.0f,  0.0f,  2.0f,  0.0f,  0.0f,  0.0f,  2.0f,  0.0f },
                { 4.0f,  3.0f,  0.0f,  0.0f,  2.0f,  5.0f,  0.0f,  2.0f,  0.0f,  0.0f,  0.0f,  2.0f,  0.0f },
                { 4.0f,  3.0f,  0.0f,  0.0f,  2.0f,  5.0f,  0.0f,  2.0f,  0.0f,  0.0f,  0.0f,  2.0f,  0.0f },
                { 2.0f,  8.0f,  4.0f,  0.0f,  1.0f,  7.0f,  0.0f,  1.0f,  0.0f,  0.0f,  3.0f,  1.0f,  0.0f },
                { 6.0f,  4.0f,  2.0f,  0.0f,  5.0f,  4.0f,  0.0f,  3.0f,  0.0f,  2.0f,  2.0f,  5.0f,  2.0f },
                { 7.0f,  2.0f,  4.0f,  4.0f,  4.0f,  2.0f,  4.0f,  4.0f,  4.0f,  0.0f,  3.0f,  6.0f,  1.0f },
                { 4.0f,  6.0f,  6.0f,  4.0f,  2.0f,  4.0f,  4.0f,  2.0f,  4.0f,  0.0f,  5.0f,  3.0f,  1.0f },
                { 0.0f,  3.0f,  6.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  4.0f,  0.0f,  0.0f },
                { 2.0f,  6.0f,  6.0f,  4.0f,  1.0f,  4.0f,  4.0f,  1.0f,  3.0f,  0.0f,  5.0f,  1.0f,  0.0f }
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    {
                        float dsweight2 = weights2[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { QuestionID = j + 5, ObjectiveID = i + 1, Weight = dsweight2 }
                        );
                    };
                }
            }

            /// Mapping 19 Questions and 40 Objectives with their weights for design factor 3
            // Define the weights as a 2D array
            /// Each element in the array represents the corresponding weight value.
            float[,] weights3 = new float[,]
            {
                { 3.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 2.0f },
                { 3.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 3.0f, 1.0f, 3.0f },
                { 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 2.0f, 0.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f },
                { 3.0f, 0.0f, 4.0f, 3.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 1.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 3.0f },
                { 3.0f, 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 1.0f, 0.0f, 1.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f },
                { 2.0f, 3.0f, 2.0f, 0.0f, 2.0f, 2.0f, 4.0f, 2.0f, 0.0f, 2.0f, 3.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 3.0f },
                { 2.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 1.0f, 0.0f, 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 1.0f },
                { 2.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 2.0f, 0.0f, 2.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f },
                { 4.0f, 2.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f },
                { 2.0f, 3.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 2.0f, 3.0f, 3.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 4.0f, 0.0f, 2.0f, 2.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 2.0f },
                { 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 1.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 3.0f, 2.0f, 2.0f, 4.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f, 0.0f, 2.0f, 4.0f, 2.0f, 0.0f, 4.0f },
                { 0.0f, 4.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 2.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 3.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 4.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 0.0f, 4.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f, 0.0f, 3.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 2.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 4.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 4.0f, 3.0f, 0.0f, 4.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 3.0f, 2.0f, 2.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 1.0f, 4.0f, 0.0f, 3.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 3.0f, 0.0f, 3.0f, 0.0f, 4.0f, 0.0f, 2.0f, 0.0f, 3.0f, 4.0f, 0.0f, 0.0f, 2.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 4.0f, 0.0f, 2.0f, 0.0f, 4.0f, 0.0f, 3.0f, 0.0f, 3.0f, 2.0f, 0.0f, 0.0f, 3.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 4.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f },
                { 1.0f, 2.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 2.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f },
                { 1.0f, 2.0f, 2.0f, 0.0f, 0.0f, 3.0f, 3.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 2.0f, 3.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f },
                { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 4.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f },
                { 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 2.0f, 4.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f }

            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    {
                        float dsweight3 = weights3[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 18, Weight = dsweight3 }
                        );
                    };

                }
            }

            /// Mapping 20 Questions and 40 Objectives with their weights for design factor 4
            float[,] weights4 = new float[,]
            {
                { 3.0f, 3.0f, 1.0f, 1.0f, 2.0f, 2.0f, 2.0f, 1.0f, 1.0f, 1.0f, 3.0f, 3.5f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 3.0f, 1.5f, 1.0f },    // EDM01
                { 2.5f, 3.0f, 1.0f, 1.0f, 1.5f, 2.5f, 2.0f, 1.5f, 0.5f, 2.5f, 1.5f, 1.0f, 3.0f, 2.0f, 1.0f, 1.0f, 2.0f, 2.0f, 1.0f, 2.5f },    // EDM02
                { 1.0f, 1.0f, 2.0f, 1.0f, 2.0f, 2.0f, 1.0f, 1.0f, 0.0f, 0.5f, 1.0f, 0.0f, 1.0f, 1.5f, 1.0f, 2.5f, 1.0f, 1.0f, 2.5f, 1.0f },    // EDM03
                { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 3.0f, 3.5f, 3.5f, 1.0f, 1.5f, 0.0f, 4.0f, 2.0f, 1.0f, 1.5f, 2.0f, 2.5f, 0.0f, 1.0f },    // EDM04
                { 1.0f, 1.0f, 1.0f, 1.0f, 1.5f, 2.0f, 1.0f, 1.0f, 0.0f, 1.0f, 3.0f, 1.5f, 1.5f, 0.5f, 0.5f, 0.5f, 1.0f, 1.0f, 1.0f, 0.0f },    // EDM05


                { 2.0f, 1.0f, 2.0f, 1.0f, 2.0f, 2.0f, 1.0f, 1.0f, 0.0f, 0.5f, 1.5f, 4.0f, 1.0f, 2.0f, 1.0f, 1.0f, 1.5f, 2.0f, 0.5f, 1.0f },    // APO01
                { 1.5f, 1.5f, 1.5f, 1.5f, 1.0f, 1.5f, 1.0f, 1.0f, 0.0f, 1.0f, 2.5f, 0.5f, 0.5f, 1.5f, 1.5f, 0.5f, 2.0f, 2.0f, 0.0f, 2.5f },    // APO02
                { 1.0f, 1.5f, 1.0f, 2.0f, 0.5f, 1.5f, 2.0f, 1.5f, 1.0f, 3.5f, 0.5f, 0.5f, 1.0f, 4.0f, 1.0f, 3.5f, 2.0f, 3.0f, 0.0f, 2.0f },    // APO03
                { 1.0f, 1.0f, 1.0f, 1.0f, 0.5f, 0.5f, 0.5f, 0.5f, 0.0f, 0.0f, 0.5f, 1.0f, 0.5f, 2.0f, 1.0f, 0.0f, 0.5f, 0.5f, 0.0f, 4.0f },    // APO04
                { 3.0f, 3.0f, 1.0f, 1.5f, 2.0f, 2.0f, 1.5f, 3.5f, 0.5f, 2.0f, 2.0f, 1.5f, 2.0f, 1.0f, 0.5f, 0.0f, 2.5f, 2.5f, 0.0f, 2.0f },    // APO05

                { 3.5f, 2.0f, 1.0f, 1.5f, 1.5f, 2.0f, 4.0f, 3.0f, 1.0f, 2.0f, 1.0f, 1.5f, 4.0f, 0.0f, 0.0f, 0.0f, 1.0f, 2.0f, 0.0f, 0.0f },    // APO06
                { 1.5f, 1.0f, 1.0f, 1.0f, 1.0f, 1.5f, 2.0f, 2.0f, 4.0f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 3.0f, 0.0f, 0.5f, 0.5f, 1.5f, 1.0f },    // APO07
                { 2.5f, 2.0f, 1.0f, 2.5f, 1.5f, 1.0f, 2.5f, 2.0f, 1.5f, 1.0f, 3.0f, 1.0f, 0.5f, 1.0f, 4.0f, 1.0f, 3.0f, 3.5f, 0.0f, 0.5f },    // APO08
                { 2.0f, 1.5f, 2.0f, 4.0f, 1.0f, 2.5f, 1.5f, 2.0f, 0.5f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.5f, 0.0f, 0.0f },    // APO09
                { 1.0f, 1.0f, 2.0f, 4.0f, 1.5f, 1.5f, 1.5f, 1.0f, 1.5f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.5f, 2.0f, 1.0f, 0.0f },    // APO10

                { 1.0f, 1.0f, 3.0f, 1.5f, 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.5f, 0.5f, 3.0f, 2.0f, 2.0f, 0.0f, 1.0f },    // APO11
                { 1.0f, 0.5f, 2.5f, 1.5f, 2.0f, 2.0f, 1.0f, 1.0f, 0.5f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 1.0f, 1.5f, 2.5f, 1.0f },    // APO12
                { 0.0f, 0.0f, 3.5f, 1.0f, 2.0f, 1.0f, 0.0f, 1.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 2.0f, 1.0f, 2.0f, 1.0f },    // APO13
                { 1.0f, 1.0f, 3.0f, 1.0f, 2.5f, 1.5f, 1.0f, 1.5f, 0.0f, 1.5f, 0.0f, 0.0f, 0.5f, 2.5f, 0.5f, 4.0f, 2.5f, 2.0f, 3.0f, 0.0f },    // APO14

                { 0.0f, 1.0f, 1.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 1.0f, 3.5f, 0.0f, 0.0f, 1.5f, 0.0f, 0.0f, 1.5f, 2.0f, 0.0f, 1.0f },    // BAI01
                { 0.0f, 3.0f, 0.0f, 0.0f, 0.5f, 0.5f, 2.0f, 0.0f, 2.0f, 0.0f, 3.5f, 0.0f, 1.0f, 1.0f, 2.0f, 1.5f, 2.5f, 3.0f, 0.5f, 1.0f },    // BAI02
                { 1.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 1.0f, 0.0f, 3.0f, 0.0f, 0.5f, 1.0f, 1.0f, 0.5f, 2.0f, 2.0f, 1.0f, 0.5f },    // BAI03
                { 0.5f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.5f, 0.0f, 1.0f, 1.0f, 1.0f, 0.0f, 0.5f },    // BAI04

                { 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.5f, 0.0f, 3.0f, 1.0f, 0.0f, 0.0f, 0.5f, 2.0f, 0.0f, 0.5f, 1.5f, 0.0f, 1.0f },    // BAI05
                { 0.0f, 0.0f, 2.5f, 3.0f, 0.5f, 1.5f, 0.0f, 1.0f, 0.0f, 1.5f, 0.0f, 1.0f, 0.5f, 1.0f, 0.5f, 2.0f, 2.0f, 2.0f, 1.0f, 1.0f },    // BAI06
                { 0.0f, 1.0f, 2.0f, 2.0f, 0.5f, 1.5f, 0.0f, 0.5f, 0.0f, 2.0f, 0.0f, 1.0f, 0.0f, 1.0f, 0.5f, 2.0f, 2.0f, 2.0f, 0.0f, 1.0f },    // BAI07
                { 0.0f, 0.0f, 0.0f, 1.5f, 0.5f, 0.5f, 0.0f, 1.0f, 2.0f, 0.5f, 0.0f, 0.5f, 0.0f, 1.0f, 3.0f, 2.0f, 1.0f, 1.5f, 0.0f, 0.5f },    // BAI08


                { 0.5f, 0.5f, 1.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 1.0f, 0.0f, 0.0f, 1.0f, 1.5f, 0.0f, 0.0f },    // BAI09
                { 0.0f, 0.0f, 2.5f, 2.0f, 0.5f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.5f, 0.0f, 1.5f, 1.0f, 2.0f, 0.0f, 0.0f },    // BAI10
                { 1.0f, 2.0f, 2.5f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f, 1.0f, 4.0f, 0.0f, 0.0f, 1.5f, 2.0f, 0.5f, 0.0f, 1.0f, 1.5f, 0.0f, 0.5f },    // BAI11

                { 0.0f, 0.0f, 2.5f, 2.0f, 1.0f, 2.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 1.5f, 1.0f, 2.0f, 0.0f, 0.0f },    // DSS01
                { 1.0f, 1.0f, 4.0f, 3.0f, 1.0f, 2.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 1.0f, 1.0f, 1.0f, 0.0f, 0.0f },    // DSS02
                { 0.0f, 1.0f, 3.0f, 3.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.5f, 1.0f, 1.0f, 1.0f, 0.5f, 0.0f },    // DSS03

                { 0.0f, 0.0f, 3.0f, 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 1.0f, 2.0f, 0.0f, 0.0f },    // DSS04
                { 0.0f, 0.0f, 4.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 1.0f, 2.0f, 2.0f, 0.0f },    // DSS05
                { 0.0f, 1.0f, 0.5f, 0.0f, 3.0f, 0.5f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 2.5f, 1.5f, 1.0f, 2.0f, 0.0f },    // DSS06

                { 1.0f, 1.5f, 2.0f, 2.0f, 2.5f, 3.0f, 1.0f, 2.0f, 1.5f, 1.0f, 1.0f, 1.0f, 2.0f, 1.0f, 1.0f, 1.0f, 1.5f, 1.0f, 2.5f, 1.0f },    // MEA01
                { 0.0f, 0.0f, 2.0f, 2.0f, 2.5f, 2.0f, 2.0f, 0.0f, 0.5f, 2.0f, 1.0f, 1.0f, 1.5f, 1.0f, 0.0f, 2.0f, 1.0f, 1.0f, 2.5f, 0.0f },    // MEA02
                { 0.0f, 0.0f, 2.0f, 2.0f, 4.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 4.0f, 0.0f },    // MEA03
                { 1.0f, 1.0f, 3.0f, 1.5f, 3.0f, 4.0f, 2.0f, 1.0f, 1.0f, 0.5f, 1.0f, 1.0f, 1.5f, 0.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.5f, 1.0f }     // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    {
                        float dsweight4 = weights4[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 37, Weight = dsweight4 }
                        );
                    };
                }
            }

            /// Mapping 2 Questions and 40 Objectives with their weights for design factor 5
            float[,] weights5 = new float[,]
            {
                { 3.0f, 1.0f },    // EDM01
                { 1.0f, 1.0f },    // EDM02
                { 4.0f, 1.0f },    // EDM03
                { 1.5f, 1.0f },    // EDM04
                { 2.0f, 1.0f },    // EDM05
                { 3.0f, 1.0f },    // APO01
                { 1.0f, 1.0f },    // APO02
                { 3.0f, 1.0f },    // APO03
                { 1.0f, 1.0f },    // APO04
                { 1.0f, 1.0f },    // APO05
                { 1.0f, 1.0f },    // APO06
                { 2.0f, 1.0f },    // APO07
                { 1.0f, 1.0f },    // APO08
                { 2.0f, 1.0f },    // APO09
                { 3.0f, 1.0f },    // APO10
                { 2.0f, 1.0f },    // APO11
                { 4.0f, 1.0f },    // APO12
                { 4.0f, 1.0f },    // APO13
                { 3.0f, 1.0f },    // APO14
                { 1.0f, 1.0f },    // BAI01
                { 1.0f, 1.0f },    // BAI02
                { 1.0f, 1.0f },    // BAI03
                { 2.0f, 1.0f },    // BAI04
                { 1.0f, 1.0f },    // BAI05
                { 3.0f, 1.0f },    // BAI06
                { 1.0f, 1.0f },    // BAI07
                { 1.0f, 1.5f },    // BAI08
                { 1.0f, 1.0f },    // BAI09
                { 3.0f, 1.0f },    // BAI10
                { 1.0f, 1.0f },    // BAI11
                { 1.0f, 1.0f },    // DSS01
                { 3.0f, 1.0f },    // DSS02
                { 2.0f, 1.0f },    // DSS03
                { 4.0f, 1.0f },    // DSS04
                { 3.0f, 1.0f },    // DSS05
                { 3.0f, 1.0f },    // DSS06
                { 3.0f, 1.0f },    // MEA01
                { 2.0f, 1.0f },    // MEA02
                { 3.0f, 1.0f },    // MEA03
                { 3.0f, 1.0f }     // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    {
                        float dsweight5 = weights5[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 57, Weight = dsweight5 }
                        );
                    };
                }
            }

            float[,] weights6 = new float[,]
            {
                { 3.0f, 2.0f, 1.0f },    // EDM01
                { 1.0f, 1.0f, 1.0f },    // EDM02
                { 4.0f, 2.0f, 1.0f },    // EDM03
                { 1.0f, 1.0f, 1.0f },    // EDM04
                { 1.5f, 1.0f, 1.0f },    // EDM05
                { 2.0f, 1.5f, 1.0f },    // APO01
                { 1.0f, 1.0f, 1.0f },    // APO02
                { 1.0f, 1.0f, 1.0f },    // APO03
                { 1.0f, 1.0f, 1.0f },    // APO04
                { 1.0f, 1.0f, 1.0f },    // APO05
                { 1.0f, 1.0f, 1.0f },    // APO06
                { 1.0f, 1.0f, 1.0f },    // APO07
                { 1.0f, 1.0f, 1.0f },    // APO08
                { 1.0f, 1.0f, 1.0f },    // APO09
                { 1.5f, 1.0f, 1.0f },    // APO10
                { 1.0f, 1.0f, 1.0f },    // APO11
                { 4.0f, 2.0f, 1.0f },    // APO12
                { 1.5f, 1.0f, 1.0f },    // APO13
                { 2.0f, 1.5f, 1.0f },    // APO14
                { 1.0f, 1.0f, 1.0f },    // BAI01
                { 1.0f, 1.0f, 1.0f },    // BAI02
                { 1.0f, 1.0f, 1.0f },    // BAI03
                { 1.0f, 1.0f, 1.0f },    // BAI04
                { 1.0f, 1.0f, 1.0f },    // BAI05
                { 1.0f, 1.0f, 1.0f },    // BAI06
                { 1.0f, 1.0f, 1.0f },    // BAI07
                { 1.0f, 1.5f, 1.5f },    // BAI08
                { 1.0f, 1.0f, 1.0f },    // BAI09
                { 1.0f, 1.0f, 1.0f },    // BAI10
                { 1.0f, 1.0f, 1.0f },    // BAI11
                { 1.0f, 1.0f, 1.0f },    // DSS01
                { 1.0f, 1.0f, 1.0f },    // DSS02
                { 1.0f, 1.0f, 1.0f },    // DSS03
                { 1.0f, 1.0f, 1.0f },    // DSS04
                { 2.0f, 1.0f, 1.0f },    // DSS05
                { 1.0f, 1.0f, 1.0f },    // DSS06
                { 1.0f, 1.0f, 1.0f },    // MEA01
                { 1.0f, 1.0f, 1.0f },    // MEA02
                { 4.0f, 2.0f, 1.0f },    // MEA03
                { 3.5f, 2.0f, 1.0f }     // MEA04
            };

            //nested for loop for all the 40 Objectives
            for (int i = 0; i < 40; i++)
            {
                // j<3 - set of questions
                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight6 = weights6[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 59, Weight = dsweight6 }
                        );
                    };
                }
            }

            /// Mapping 4 Questions and 40 Objectives with their weights for design factor 7
            float[,] weights7 = new float[,]
            {
                { 1.0f, 2.0f, 1.5f, 4.0f },
                { 1.0f, 1.0f, 2.5f, 3.0f },
                { 1.0f, 3.0f, 1.0f, 3.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.5f, 1.5f, 2.5f },
                { 1.0f, 1.0f, 3.0f, 3.0f },
                { 1.0f, 1.0f, 2.0f, 2.0f },
                { 0.5f, 1.0f, 3.5f, 4.0f },
                { 1.0f, 1.0f, 2.5f, 3.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 1.5f },
                { 1.0f, 1.0f, 2.0f, 2.5f },
                { 1.0f, 2.0f, 1.5f, 2.0f },
                { 1.0f, 2.5f, 1.5f, 2.0f },
                { 1.0f, 1.5f, 1.5f, 2.0f },
                { 1.0f, 2.5f, 1.0f, 3.0f },
                { 1.0f, 2.0f, 1.5f, 3.0f },
                { 1.0f, 1.5f, 1.5f, 2.5f },
                { 1.0f, 1.0f, 2.0f, 2.5f },
                { 1.0f, 1.0f, 3.0f, 3.0f },
                { 1.0f, 1.0f, 3.0f, 3.0f },
                { 1.0f, 2.5f, 1.5f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 2.5f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 2.0f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.5f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 2.0f, 2.0f },
                { 1.0f, 3.5f, 1.0f, 3.0f },
                { 1.0f, 3.0f, 1.5f, 3.0f },
                { 1.0f, 3.0f, 1.5f, 3.5f },
                { 1.0f, 3.0f, 1.5f, 3.5f },
                { 1.5f, 2.5f, 1.5f, 3.5f },
                { 1.0f, 1.0f, 1.0f, 2.5f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 2.0f },
                { 1.0f, 1.0f, 1.0f, 1.5f },
                { 1.0f, 1.0f, 1.0f, 2.0f }
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    {
                        float dsweight7 = weights7[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 62, Weight = dsweight7 }
                        );
                    }
                }
            }

            /// Mapping 3 Questions and 40 Objectives with their weights for design factor 8
            float[,] weights8 = new float[,]
            {
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 2.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 4.0f, 4.0f, 1.0f },
                { 4.0f, 4.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 2.0f, 2.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 3.0f, 3.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f }
            };

            for (int i = 0; i < 40; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight7 = weights8[i, j];
                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 66, Weight = dsweight7 }
                        );
                    };
                }
            }


            /// Mapping 3 Questions and 40 Objectives with their weights for design factor 9
            float[,] weights9 = new float[,]
            {
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 2.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 2.0f, 1.5f, 1.0f },
                { 3.5f, 2.0f, 1.0f },
                { 4.0f, 3.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 2.5f, 1.5f, 1.0f },
                { 3.5f, 2.0f, 1.0f },
                { 2.5f, 2.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.5f, 2.0f, 1.0f },
                { 2.5f, 1.0f, 1.0f },
                { 1.0f, 2.5f, 1.0f },
                { 1.0f, 1.5f, 1.0f },
                { 1.0f, 1.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.5f, 1.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f }
            };

            for (int i = 0; i < 40; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight7 = weights9[i, j];

                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 69, Weight = dsweight7 }
                        );
                    };
                }
            }

            /// Mapping 3 Questions and 40 Objectives with their weights for design factor 10
            float[,] weights10 = new float[,]
            {
                { 3.5f, 2.5f, 1.5f },
                { 4.0f, 2.5f, 1.5f },
                { 1.5f, 1.0f, 1.0f },
                { 2.5f, 2.0f, 1.5f },
                { 1.5f, 1.0f, 1.0f },
                { 2.5f, 1.5f, 1.0f },
                { 4.0f, 3.0f, 1.5f },
                { 2.0f, 1.0f, 1.0f },
                { 4.0f, 3.0f, 1.0f },
                { 4.0f, 2.5f, 1.0f },
                { 1.0f, 1.5f, 1.0f },
                { 2.5f, 1.0f, 1.0f },
                { 3.0f, 1.5f, 1.0f },
                { 1.5f, 1.5f, 1.0f },
                { 2.5f, 1.5f, 1.0f },
                { 1.5f, 1.5f, 1.0f },
                { 2.0f, 1.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 2.5f, 2.0f, 1.0f },
                { 4.0f, 3.0f, 1.5f },
                { 3.5f, 2.5f, 1.0f },
                { 4.0f, 2.5f, 1.0f },
                { 1.5f, 1.5f, 1.0f },
                { 3.0f, 2.0f, 1.0f },
                { 2.5f, 2.0f, 1.0f },
                { 3.5f, 2.5f, 1.0f },
                { 1.5f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.5f, 1.0f, 1.0f },
                { 3.5f, 2.5f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.5f, 1.0f, 1.0f },
                { 1.5f, 1.0f, 1.0f },
                { 1.5f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 3.0f, 2.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f },
                { 1.0f, 1.0f, 1.0f }
            };

            for (int i = 0; i < 40; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight7 = weights10[i, j];

                        builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 72, Weight = dsweight7 }
                        );
                    }
                }
            }

            string coreModelDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(),"Data", "Seeding", "AuditJSONs", "Cobit Core Model");

            string[] files = Directory.GetFiles(coreModelDirectoryPath);
            int objectiveAuditID = 0;
            foreach (string file in files)
            {
                objectiveAuditID++;
                string fileName = Path.GetFileNameWithoutExtension(file);
                int objectiveID = int.Parse(fileName.Substring(8));
                string auditObject = File.ReadAllText(file);

                builder.Entity<ObjectiveAuditTemplateModel>().HasData(new ObjectiveAuditTemplateModel { AuditObject = auditObject, ObjectiveID = objectiveID, FocusAreaID = 1 });
                //Audit ID 1
                builder.Entity<ObjectiveAuditModel>().HasData(new ObjectiveAuditModel { ID = objectiveAuditID, AuditID = 1, ObjectiveID = objectiveID, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", UserAuditObject = auditObject });
            }
        }
    }
}
