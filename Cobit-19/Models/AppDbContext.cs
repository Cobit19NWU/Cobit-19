using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Emit;

namespace Cobit_19.Models
{
    public class AppDbContext : DbContext
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
        public DbSet<AuditScopeModel> AuditScopes { get; set; }
        public DbSet<MapModel> Maps { get; set; }

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
            builder.Entity<AuditScopeModel>().ToTable("AuditScopes");
            builder.Entity<MapModel>().ToTable("Maps");

            // Relationships

            builder.Entity<AnswerModel>()
                .HasKey(table => new {
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

            builder.Entity<AuditScopeModel>()
                .HasKey(table => new {
                    table.AuditID,
                    table.ObjectiveID
            });

            builder.Entity<AuditModel>()
                .HasMany(d => d.AuditScopes)
                .WithOne(d => d.Audit)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ObjectiveModel>()
                .HasMany(d => d.AuditScopes)
                .WithOne(d => d.Objective)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MapModel>()
                .HasKey(table => new {
                    table.ObjectiveID,
                    table.QuestionID
            });

            builder.Entity<ObjectiveModel>()
                .HasMany(d => d.Maps)
                .WithOne(d => d.Objective)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<QuestionModel>()
                .HasMany(d => d.Maps)
                .WithOne(d => d.Question)
                .OnDelete(DeleteBehavior.Cascade);

            // Data seeding

            builder.Entity<FocusAreaModel>().HasData(
                new FocusAreaModel { ID = 1, Name = "Cobit Core Model", Description = "General Core Model", DateCreated = DateTime.Parse("Jan 1, 2009") });

            builder.Entity<DesignFactorModel>().HasData(
                new DesignFactorModel { ID = 1, FocusAreaID = 1, Name = "1", Description = "Ensure Governance Framework Setting and Maintenance" },
                new DesignFactorModel { ID = 2, FocusAreaID = 1, Name = "2", Description = "Ensure Benefits Delivery" }
                );

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel { ID = 1, DesignFactorID = 1, Question = "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?", DefaultAnswer = 1 },
                new QuestionModel { ID = 2, DesignFactorID = 1, Question = "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?", DefaultAnswer = 1 },
                new QuestionModel { ID = 3, DesignFactorID = 1, Question = "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?", DefaultAnswer = 1 }
                );

            builder.Entity<AuditModel>().HasData(
                new AuditModel { ID = 1, FocusAreaID = 1, UserID = 1, Name = "Audit 1", DateCreated = DateTime.Parse("Jan 1, 2009"), Status = AuditStatus.InProgress },
                new AuditModel { ID = 2, FocusAreaID = 1, UserID = 1, Name = "Audit 2", DateCreated = DateTime.Parse("Jan 2, 2009"), Status = AuditStatus.InProgress }
                );
            builder.Entity<AnswerModel>().HasData(
                new AnswerModel { AuditID = 1, QuestionID = 1, Answer = 1 },
                new AnswerModel { AuditID = 1, QuestionID = 2, Answer = 1 },
                new AnswerModel { AuditID = 1, QuestionID = 3, Answer = 1 },
                new AnswerModel { AuditID = 2, QuestionID = 1, Answer = 1 },
                new AnswerModel { AuditID = 2, QuestionID = 2, Answer = 1 },
                new AnswerModel { AuditID = 2, QuestionID = 3, Answer = 1 }
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
                new ObjectiveModel { ID = 27, Name = "BAI07", Code = "BAI07", Description = "Manage IT Change Acceptance and Transitioning" },
                new ObjectiveModel { ID = 27, Name = "BAI08", Code = "BAI08", Description = "Manage Knowledge" },
                new ObjectiveModel { ID = 28, Name = "BAI09", Code = "BAI09", Description = "Manage Assets" },
                new ObjectiveModel { ID = 39, Name = "BAI10", Code = "BAI010", Description = "Manage Configuration" },
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
                new ObjectiveModel { ID = 39, Name = "MEA04", Code = "MEA04", Description = "Manage Assurance" }
                );

            builder.Entity<AuditScopeModel>().HasData(
                new AuditScopeModel { AuditID = 1, ObjectiveID = 1, UserID = 1 },
                new AuditScopeModel { AuditID = 1, ObjectiveID = 2, UserID = 1 },
                new AuditScopeModel { AuditID = 1, ObjectiveID = 3, UserID = 1 }
                );

            builder.Entity<MapModel>().HasData(
                new MapModel { ObjectiveID = 1, QuestionID = 1, Weight = 1 },
                new MapModel { ObjectiveID = 1, QuestionID = 2, Weight = 0.5f },
                new MapModel { ObjectiveID = 1, QuestionID = 3, Weight = 0.1f }
                );
        }
    }
}
