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
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "5e70cf29-1b64-4f58-85dd-07b3c46015a3", Name = "Governance Auditor", NormalizedName = "GOVERNANCE AUDITOR".ToUpper() });
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
                    PasswordHash = hasher.HashPassword(null, "7410852"),
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
                    PasswordHash = hasher.HashPassword(null, "7410852"),
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
                    PasswordHash = hasher.HashPassword(null, "7410852"),
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
                    PasswordHash = hasher.HashPassword(null, "7410852"),
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
                    PasswordHash = hasher.HashPassword(null, "7410852"),
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
                new AuditMemberModel { ApplicationUserID = "fa567c12-5678-4321-bacd-87654321de1f", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "9b1a0f34-8765-4321-dcba-ba09876543c2", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "b2c3d4e5-f6a7-1234-5678-0987654321dc", AuditID = 1 },
                new AuditMemberModel { ApplicationUserID = "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", AuditID = 1 });

            builder.Entity<FocusAreaModel>().HasData(
                new FocusAreaModel { ID = 1, Name = "Cobit 2019", Description = "Core Model", DateCreated = DateTime.Parse("Jan 1, 2023"), ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            builder.Entity<DesignFactorModel>().HasData(
                new DesignFactorModel { ID = 1, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 1", Description = "Enterprise Strategy", Information = "Enterprises adopt various strategies, represented by archetypes. Rate each of the four values for the enterprise strategy design factor on a scale of 1 to 5, with 5 being the most important. Ensure an appropriate spread between the ratings." },
                new DesignFactorModel { ID = 2, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 2", Description = "Enterprise Goals", Information = "Rate each of the thirteen enterprise goals on a scale of 1 to 5, with 5 being the most important. Identify the top three to five critical goals using generic enterprise goals. Limiting high-priority goals ensures more meaningful goal cascade results; maintain an adequate spread between values." },
                new DesignFactorModel { ID = 3, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 3", Description = "Risk Profile", Information = "The risk profile assesses IT-related risks faced by the enterprise, highlighting areas surpassing the risk appetite. All 19 risk categories in the design factor must be rated on a scale of 1 to 5, indicating the potential impact of each risk (1 being insignificant, 5 being critical)." },
                new DesignFactorModel { ID = 4, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 4", Description = "IT-Related Issues", Information = "For an enterprise I&T risk assessment, consider current I&T-related issues or risks that have materialized. Maintain an adequate spread between values." },
                new DesignFactorModel { ID = 5, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 5", Description = "Threat landscape", Information = "The enterprise's threat landscape falls into two categories: Normal - operating under typical threat levels, and High - due to geopolitical factors, industry sector, or specific profile, operating in a high-threat environment." },
                new DesignFactorModel { ID = 6, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 6", Description = "Compliance Requirements", Information = "The enterprise's compliance requirements fall into three categories: Low - minimal requirements below average, Normal - common industry-standard requirements, and High - above-average requirements often tied to industry or geopolitical conditions." },
                new DesignFactorModel { ID = 7, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 7", Description = "Role of IT", Information = "IT's role for the enterprise can be categorized as follows: Support - Not crucial for business processes, services, or innovation. Factory - Immediate impact on processes and services if IT fails, but not a driver for innovation. Turnaround - Seen as a driver for innovating processes and services, though not critical for current operations." },
                new DesignFactorModel { ID = 8, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 8", Description = "Sourcing model for IT", Information = "The enterprise's sourcing model can be categorized as: Outsourcing - utilizing third-party IT services, Cloud - maximizing cloud services, and Insourced - managing IT staff and services internally." },
                new DesignFactorModel { ID = 9, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 9", Description = "IT implementation methods", Information = "The enterprise's methods can be categorized as: Agile - using Agile development for software development, DevOps - employing DevOps for software building, deployment, and operations, and Traditional - following a classic approach (waterfall) that separates software development and operations." },
                new DesignFactorModel { ID = 10, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 10", Description = "Technology Adoption Strategy", Information = "The technology adoption strategy can be categorized as: First mover - early adoption for a first-mover advantage, Follower - waiting for technology to become mainstream, and Slow adopter - late adoption of new technologies." }
                //new DesignFactorModel { ID = 11, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 11", Description = "Enterprise Size" }
                );

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel { ID = 1, DesignFactorID = 1, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the importance of pursuing growth/acquisition for revenue expansion in our enterprise" },
                new QuestionModel { ID = 2, DesignFactorID = 1, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the importance of the enterprise's focus on offering different/innovative products and services to clients" },
                new QuestionModel { ID = 3, DesignFactorID = 1, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the importance of the enterprise's focus on short-term cost minimization through cost leadership" },
                new QuestionModel { ID = 4, DesignFactorID = 1, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the importance of the enterprise's focus on providing stable and client-oriented services" },
             
                new QuestionModel { ID = 5, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG01 - Rate the importance of maintaining a competitive portfolio of products and services in the enterprise" },
                new QuestionModel { ID = 6, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG02 - Rate the importance of effectively managing business risks in the enterprise" },
                new QuestionModel { ID = 7, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG03 - Rate the importance of ensuring compliance with external laws and regulations in the enterprise" },
                new QuestionModel { ID = 8, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG04 - Rate the importance of maintaining high-quality financial information in the enterprise" },
                new QuestionModel { ID = 9, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG05 - Rate the importance of fostering a customer-oriented service culture in the enterprise" },
                new QuestionModel { ID = 10, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG06 - Rate the importance of ensuring business service continuity and availability in the enterprise" },
                new QuestionModel { ID = 11, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG07 - Rate the importance of maintaining high-quality management information in the enterprise" },
                new QuestionModel { ID = 12, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG08 - Rate the importance of optimizing internal business process functionality in the enterprise" },
                new QuestionModel { ID = 13, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG09 - Rate the importance of optimizing costs associated with internal business processes in the enterprise" },
                new QuestionModel { ID = 14, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG10 - Rate the importance of enhancing staff skills, motivation, and productivity in the enterprise" },
                new QuestionModel { ID = 15, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG11 - Rate the importance of ensuring compliance with internal policies within the enterprise" },
                new QuestionModel { ID = 16, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG12 - Rate the importance of effectively managing digital transformation programs in the enterprise" },
                new QuestionModel { ID = 17, DesignFactorID = 2, BaseAnswer = 3, AnswerRange = 5, Question = "EG13 - Rate the importance of fostering product and business innovation in the enterprise" },
                
                new QuestionModel { ID = 18, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2,  Question = "To what extent do you perceive the current state of IT-investment decision making, portfolio definition, and maintenance within the enterprise as contributing to its risk profile?" },
                new QuestionModel { ID = 19, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the effectiveness of the current Program and Projects Lifecycle Management in mitigating IT-related risks within the enterprise?" },
                new QuestionModel { ID = 20, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent do you believe the current IT cost and oversight practices contribute to the enterprise's overall risk profile?" },
                new QuestionModel { ID = 21, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the alignment of current IT expertise, skills, and behavior with the enterprise's risk mitigation objectives?" },
                new QuestionModel { ID = 22, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent does the current Enterprise/IT architecture align with and support the enterprise's risk management objectives?" },
                new QuestionModel { ID = 23, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the impact of current IT operational infrastructure incidents on the enterprise's overall risk exposure?" },
                new QuestionModel { ID = 24, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent do unauthorized actions pose a risk to the enterprise's IT environment and overall risk profile?" },
                new QuestionModel { ID = 25, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the impact of current software adoption/usage problems on the enterprise's overall risk landscape?" },
                new QuestionModel { ID = 26, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent do hardware incidents contribute to the enterprise's overall risk exposure in the IT environment?" },
                new QuestionModel { ID = 27, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the impact of current software failures on the enterprise's overall risk profile?" },
                new QuestionModel { ID = 28, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent do logical attacks (hacking, malware, etc.) pose a risk to the security and integrity of the enterprise's IT infrastructure?" },
                new QuestionModel { ID = 29, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the impact of current third-party/supplier incidents on the enterprise's overall risk exposure?" },
                new QuestionModel { ID = 30, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent does noncompliance with regulatory standards and internal policies contribute to the enterprise's overall risk profile?" },
                new QuestionModel { ID = 31, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the influence of current geopolitical issues on the enterprise's overall risk exposure, particularly in the realm of Information Technology?" },
                new QuestionModel { ID = 32, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent do current or potential industrial actions pose a risk to the enterprise's IT operations and overall risk profile?" },
                new QuestionModel { ID = 33, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the susceptibility of the enterprise to acts of nature (e.g., natural disasters) in terms of potential risks to IT infrastructure and operations?" },
                new QuestionModel { ID = 34, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent does technology-based innovation contribute to the enterprise's overall risk exposure, considering factors such as adoption challenges and potential disruptions?" },
                new QuestionModel { ID = 35, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "How would you rate the influence of current environmental factors (e.g., sustainability concerns, climate change) on the enterprise's overall risk exposure, particularly in the context of Information Technology?" },
                new QuestionModel { ID = 36, DesignFactorID = 3, BaseAnswer = 3, AnswerRange = 5, Odds = 2, Question = "To what extent does the current data and information management strategy contribute to the enterprise's risk profile, considering factors such as data security, privacy, and integrity?" },
                ///
                new QuestionModel { ID = 37, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent is there frustration among various IT entities across the organization due to a perceived low contribution to business value?" },
                new QuestionModel { ID = 38, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what degree is there frustration between business departments (i.e., the IT customer) and the IT department, stemming from either failed initiatives or a perceived low contribution to business value?" },
                new QuestionModel { ID = 39, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent have significant IT-related incidents, such as data loss, security breaches, project failure, and application errors, been associated with IT?" },
                new QuestionModel { ID = 40, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what degree are service delivery problems observed with the IT outsourcer(s)?" },
                new QuestionModel { ID = 41, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent are there failures to meet IT-related regulatory or contractual requirements?" },
                new QuestionModel { ID = 42, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "How frequently do regular audit findings or other assessment reports highlight poor IT performance or reported IT quality or service problems?" },
                new QuestionModel { ID = 43, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent is there substantial hidden and rogue IT spending, referring to IT expenditures by user departments outside the control of the usual IT investment decision mechanisms and approved budgets?" },
                new QuestionModel { ID = 44, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what degree are there duplications or overlaps between various initiatives, or other forms of wasted resources?" },
                new QuestionModel { ID = 45, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent are there insufficient IT resources, staff with inadequate skills, or staff burnout/dissatisfaction?" },
                new QuestionModel { ID = 46, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what degree do IT-enabled changes or projects frequently fail to meet business needs and are delivered late or over budget?" },
                new QuestionModel { ID = 47, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent is there reluctance among board members, executives, or senior management to engage with IT, or a lack of committed business sponsorship for IT?" },
                new QuestionModel { ID = 48, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what degree is there a complex IT operating model and/or unclear decision mechanisms for IT-related decisions?" },
                new QuestionModel { ID = 49, DesignFactorID = 4, BaseAnswer = 1, AnswerRange = 3, Question = "To what extent is there an excessively high cost of IT?" },
                new QuestionModel { ID = 50, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "To what degree is the implementation of new initiatives or innovations obstructed or failed due to the current IT architecture and systems?" },
                new QuestionModel { ID = 51, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "To what extent is there a gap between business and technical knowledge, resulting in business users and information and/or technology specialists speaking different languages?" },
                new QuestionModel { ID = 52, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "How frequently are there issues with data quality and integration across various sources?" },
                new QuestionModel { ID = 53, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "To what extent is there a high level of end-user computing, leading to issues such as a lack of oversight and quality control over the applications that are being developed and put into operation?" },
                new QuestionModel { ID = 54, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "To what degree do business departments implement their own information solutions with little or no involvement of the enterprise IT department, particularly in relation to end-user computing, often stemming from dissatisfaction with IT solutions and services?" },
                new QuestionModel { ID = 55, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "To what extent is there ignorance of and/or noncompliance with privacy regulations?" },
                new QuestionModel { ID = 56, DesignFactorID = 4, BaseAnswer = 2, AnswerRange = 3, Question = "To what degree is there an inability to exploit new technologies or innovate using Information and Technology (I&T)?" },
                ////
                new QuestionModel { ID = 57, DesignFactorID = 5, BaseAnswer = 33, AnswerRange = 100, Question = "To what degree is the enterprise operating in a high-threat environment due to factors such as its geopolitical situation, industry sector, or specific profile?" },
                new QuestionModel { ID = 58, DesignFactorID = 5, BaseAnswer = 67, AnswerRange = 100, Question = "To what degree is the enterprise currently facing threat levels that are deemed normal in the operating landscape?" },
                ///
                new QuestionModel { ID = 59, DesignFactorID = 6, BaseAnswer = 0, AnswerRange = 100, Question = "To what degree is the enterprise subjected to higher than average compliance requirements, most often related to industry sector or geopolitical conditions?" },
                new QuestionModel { ID = 60, DesignFactorID = 6, BaseAnswer = 100, AnswerRange = 100, Question = "To what degree is the enterprise subjected to a set of regular compliance requirements that are common across different industries?" },
                new QuestionModel { ID = 61, DesignFactorID = 6, BaseAnswer = 0, AnswerRange = 100, Question = "To what degree is the enterprise subjected to a minimal set of regular compliance requirements that are lower than average?" },
                ///
                new QuestionModel { ID = 62, DesignFactorID = 7, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the importance of IT not being crucial for the running, continuity, and innovation of the business process and services" },
                new QuestionModel { ID = 63, DesignFactorID = 7, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the impact of IT on the running and continuity of business processes and services in the event of failure. Additionally, consider the role of IT as a driver for innovating business processes and services." },
                new QuestionModel { ID = 64, DesignFactorID = 7, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the importance of IT as a driver for innovating business processes and services. Additionally, consider the current critical dependency of IT for the running and continuity of business processes and services" },
                new QuestionModel { ID = 65, DesignFactorID = 7, BaseAnswer = 3, AnswerRange = 5, Question = "Rate the criticality of IT for both the current running and innovating the organization’s business processes and services" },
                ///
                new QuestionModel { ID = 66, DesignFactorID = 8, BaseAnswer = 33, AnswerRange = 100, Question = "To what degree does the enterprise call upon the services of a third party to provide IT services?" },
                new QuestionModel { ID = 67, DesignFactorID = 8, BaseAnswer = 33, AnswerRange = 100, Question = "To what degree does the enterprise maximize the use of the cloud for providing IT services to its users?" },
                new QuestionModel { ID = 68, DesignFactorID = 8, BaseAnswer = 33, AnswerRange = 100, Question = "To what degree does the enterprise provide for their own IT staff and services?" },
                ///                                                               AnswerRange = 100,
                new QuestionModel { ID = 69, DesignFactorID = 9, BaseAnswer = 15, AnswerRange = 100, Question = "To what degree does the enterprise use Agile development working methods for its software development?" },
                new QuestionModel { ID = 70, DesignFactorID = 9, BaseAnswer = 10, AnswerRange = 100, Question = "To what degree does the enterprise use DevOps working methods for software building, deployment and operations?" },
                new QuestionModel { ID = 71, DesignFactorID = 9, BaseAnswer = 75, AnswerRange = 100, Question = "To what degree does the enterprise use a more classic approach towards software development (waterfall) and separates software development and operations?" },
                ///
                new QuestionModel { ID = 72, DesignFactorID = 10, BaseAnswer = 15, AnswerRange = 100, Question = "To which extent does the enterprise generally adopt new technologies as early as possible to try gain first-mover advantage?", },
                new QuestionModel { ID = 73, DesignFactorID = 10, BaseAnswer = 70, AnswerRange = 100, Question = "To which extent does the enterprise typically wait for new technology to become mainstream and proven before adopting them?" },
                new QuestionModel { ID = 74, DesignFactorID = 10, BaseAnswer = 15, AnswerRange = 100, Question = "To which extent is the enterprise very late with their adoption of new technologies?" }
                );

            builder.Entity<AuditModel>().HasData(
                new AuditModel { ID = 1, FocusAreaID = 1, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", Name = "Audit 1", DateCreated = DateTime.Parse("Jan 1, 2009"), Status = AuditStatus.InProgress }
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
                builder.Entity<ObjectiveAuditMembersModel>().HasData(new ObjectiveAuditMembersModel { ObjectiveAuditID = objectiveAuditID, ApplicationUserID = "8e445865-a24d-4543-a6c6-9443d048cdb9", DateAdded = DateTime.Now });
                builder.Entity<ObjectiveAuditMembersModel>().HasData(new ObjectiveAuditMembersModel { ObjectiveAuditID = objectiveAuditID, ApplicationUserID = "fa567c12-5678-4321-bacd-87654321de1f", DateAdded = DateTime.Now });
                builder.Entity<ObjectiveAuditMembersModel>().HasData(new ObjectiveAuditMembersModel { ObjectiveAuditID = objectiveAuditID, ApplicationUserID = "b2c3d4e5-f6a7-1234-5678-0987654321dc", DateAdded = DateTime.Now });
            }
        }
    }
}