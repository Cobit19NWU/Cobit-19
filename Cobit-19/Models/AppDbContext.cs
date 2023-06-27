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
                new ObjectiveModel { ID = 1, Name = "EDM01", Code = "EDM01", Description = "Ensure Governance Framework Setting and Maintenance" },
                new ObjectiveModel { ID = 2, Name = "EDM02", Code = "EDM02", Description = "Ensure Benefits Delivery" },
                new ObjectiveModel { ID = 3, Name = "EDM03", Code = "EDM03", Description = "Ensure Risk Optimisation" },
                new ObjectiveModel { ID = 4, Name = "EDM04", Code = "EDM04", Description = "Ensure Resource Optimisation" },
                new ObjectiveModel { ID = 5, Name = "EDM05", Code = "EDM05", Description = "Ensure Stakeholder Transparency" },
                new ObjectiveModel { ID = 6, Name = "APO01", Code = "APO01", Description = "Manage the IT Management Frameworks" }
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
