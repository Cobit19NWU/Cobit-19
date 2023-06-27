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
                new DesignFactorModel { ID = 1, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 1", Description = "Enterprise Strategy" },
                new DesignFactorModel { ID = 2, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 2", Description = "Enterprise Goals" },
                new DesignFactorModel { ID = 3, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 3", Description = "Risk Profile" },
                new DesignFactorModel { ID = 4, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 4", Description = "IT-Related Issues" },
                new DesignFactorModel { ID = 5, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 5", Description = "Threat landscape" },
                new DesignFactorModel { ID = 6, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 6", Description = "Compliance Requirements" },
                new DesignFactorModel { ID = 7, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 7", Description = "Role of IT" },
                new DesignFactorModel { ID = 8, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 8", Description = "Sourcing model for IT" },
                new DesignFactorModel { ID = 9, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 9", Description = "IT implementation methods" },
                new DesignFactorModel { ID = 10, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 10", Description = "Technology adoption strategy" },
                new DesignFactorModel { ID = 11, FocusAreaID = 1, Name = "Cobit Core Model - Design Factor 11", Description = "Enterprise Size" }
                );

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel { ID = 1, DesignFactorID = 1, Question = "Growth/Acquisition", DefaultAnswer = 3 },
                new QuestionModel { ID = 2, DesignFactorID = 1, Question = "Innovation/Differentiation", DefaultAnswer = 3 },
                new QuestionModel { ID = 3, DesignFactorID = 1, Question = "Cost Leadership", DefaultAnswer = 3 },
                new QuestionModel { ID = 4, DesignFactorID = 1, Question = "Client Service/Stability", DefaultAnswer = 3 },
                ////
                new QuestionModel { ID = 5, DesignFactorID = 2, Question = "EG01—Portfolio of competitive products and services", DefaultAnswer = 3 },
                new QuestionModel { ID = 6, DesignFactorID = 2, Question = "EG02—Managed business risk", DefaultAnswer = 3 },
                new QuestionModel { ID = 7, DesignFactorID = 2, Question = "EG03—Compliance with external laws and regulations", DefaultAnswer = 3 },
                new QuestionModel { ID = 8, DesignFactorID = 2, Question = "EG04—Quality of financial information", DefaultAnswer = 3 },
                new QuestionModel { ID = 9, DesignFactorID = 2, Question = "EG05—Customer-oriented service culture", DefaultAnswer = 3 },
                new QuestionModel { ID = 10, DesignFactorID = 2, Question = "EG06—Business-service continuity and availability", DefaultAnswer = 3 },
                new QuestionModel { ID = 11, DesignFactorID = 2, Question = "EG07—Quality of management information", DefaultAnswer = 3 },
                new QuestionModel { ID = 12, DesignFactorID = 2, Question = "EG08—Optimization of internal business process functionality", DefaultAnswer = 3 },
                new QuestionModel { ID = 13, DesignFactorID = 2, Question = "EG09—Optimization of business process costs", DefaultAnswer = 3 },
                new QuestionModel { ID = 14, DesignFactorID = 2, Question = "EG10—Staff skills, motivation and productivity", DefaultAnswer = 3 },
                new QuestionModel { ID = 15, DesignFactorID = 2, Question = "EG11—Compliance with internal policies", DefaultAnswer = 3 },
                new QuestionModel { ID = 16, DesignFactorID = 2, Question = "EG12—Managed digital transformation programs", DefaultAnswer = 3 },
                new QuestionModel { ID = 17, DesignFactorID = 2, Question = "EG13—Product and business innovation", DefaultAnswer = 3 },
                ///
                new QuestionModel { ID = 18, DesignFactorID = 3, Question = "IT investment decision-making, portfolio definition & maintenance", DefaultAnswer = 9 },
                new QuestionModel { ID = 19, DesignFactorID = 3, Question = "Program & projects life cycle management", DefaultAnswer = 9 },
                new QuestionModel { ID = 20, DesignFactorID = 3, Question = "IT cost & oversight", DefaultAnswer = 9 },
                new QuestionModel { ID = 21, DesignFactorID = 3, Question = "IT expertise, skills & behaviour", DefaultAnswer = 9 },
                new QuestionModel { ID = 22, DesignFactorID = 3, Question = "Enterprise/IT architecture", DefaultAnswer = 9 },
                new QuestionModel { ID = 23, DesignFactorID = 3, Question = "IT operational infrastructure incidents", DefaultAnswer = 9 },
                new QuestionModel { ID = 24, DesignFactorID = 3, Question = "Unauthorized actions", DefaultAnswer = 9 },
                new QuestionModel { ID = 25, DesignFactorID = 3, Question = "Software adoption/usage problems", DefaultAnswer = 9 },
                new QuestionModel { ID = 26, DesignFactorID = 3, Question = "Hardware incidents", DefaultAnswer = 9 },
                new QuestionModel { ID = 27, DesignFactorID = 3, Question = "Software failures", DefaultAnswer = 9 },
                new QuestionModel { ID = 28, DesignFactorID = 3, Question = "Logical attacks (hacking, malware, etc.)", DefaultAnswer = 9 },
                new QuestionModel { ID = 29, DesignFactorID = 3, Question = "Third-party/supplier incidents", DefaultAnswer = 9 },
                new QuestionModel { ID = 30, DesignFactorID = 3, Question = "Noncompliance", DefaultAnswer = 9 },
                new QuestionModel { ID = 31, DesignFactorID = 3, Question = "Geopolitical Issues", DefaultAnswer = 9 },
                new QuestionModel { ID = 32, DesignFactorID = 3, Question = "Industrial action", DefaultAnswer = 9 },
                new QuestionModel { ID = 33, DesignFactorID = 3, Question = "Acts of nature", DefaultAnswer = 9 },
                new QuestionModel { ID = 34, DesignFactorID = 3, Question = "Technology-based innovation", DefaultAnswer = 9 },
                new QuestionModel { ID = 35, DesignFactorID = 3, Question = "Environmental", DefaultAnswer = 9 },
                new QuestionModel { ID = 36, DesignFactorID = 3, Question = "Data & information management", DefaultAnswer = 9 },
                ///
                new QuestionModel { ID = 37, DesignFactorID = 4, Question = "Frustration between different IT entities across the organization because of a perception of low contribution to business value", DefaultAnswer = 1 },
                new QuestionModel { ID = 38, DesignFactorID = 4, Question = "Frustration between business departments (i.e., the IT customer) and the IT department because of failed initiatives or a perception of low contribution to business value", DefaultAnswer = 1 },
                new QuestionModel { ID = 39, DesignFactorID = 4, Question = "Significant IT-related incidents, such as data loss, security breaches, project failure and application errors, linked to IT", DefaultAnswer = 1 },
                new QuestionModel { ID = 40, DesignFactorID = 4, Question = "Service delivery problems by the IT outsourcer(s)", DefaultAnswer = 1 },
                new QuestionModel { ID = 41, DesignFactorID = 4, Question = "Failures to meet IT-related regulatory or contractual requirements", DefaultAnswer = 1 },
                new QuestionModel { ID = 42, DesignFactorID = 4, Question = "Regular audit findings or other assessment reports about poor IT performance or reported IT quality or service problems", DefaultAnswer = 1 },
                new QuestionModel { ID = 43, DesignFactorID = 4, Question = "Substantial hidden and rogue IT spending, that is, IT spending by user departments outside the control of the normal IT investment decision mechanisms and approved budgets", DefaultAnswer = 1 },
                new QuestionModel { ID = 44, DesignFactorID = 4, Question = "Duplications or overlaps between various initiatives, or other forms of wasted resources", DefaultAnswer = 1 },
                new QuestionModel { ID = 45, DesignFactorID = 4, Question = "Insufficient IT resources, staff with inadequate skills or staff burnout/dissatisfaction", DefaultAnswer = 1 },
                new QuestionModel { ID = 46, DesignFactorID = 4, Question = "IT-enabled changes or projects frequently failing to meet business needs and delivered late or over budget", DefaultAnswer = 1 },
                new QuestionModel { ID = 47, DesignFactorID = 4, Question = "Reluctance by board members, executives or senior management to engage with IT, or a lack of committed business sponsorship for IT", DefaultAnswer = 1 },
                new QuestionModel { ID = 48, DesignFactorID = 4, Question = "Complex IT operating model and/or unclear decision mechanisms for IT-related decisions", DefaultAnswer = 1 },
                new QuestionModel { ID = 49, DesignFactorID = 4, Question = "Excessively high cost of IT", DefaultAnswer = 1 },
                new QuestionModel { ID = 50, DesignFactorID = 4, Question = "Obstructed or failed implementation of new initiatives or innovations caused by the current IT architecture and systems", DefaultAnswer = 2 },
                new QuestionModel { ID = 51, DesignFactorID = 4, Question = "Gap between business and technical knowledge, which leads to business users and information and/or technology specialists speaking different languages", DefaultAnswer = 2 },
                new QuestionModel { ID = 52, DesignFactorID = 4, Question = "Regular issues with data quality and integration of data across various sources", DefaultAnswer = 2 },
                new QuestionModel { ID = 53, DesignFactorID = 4, Question = "High level of end-user computing, creating (among other problems) a lack of oversight and quality control over the applications that are being developed and put in operation", DefaultAnswer = 2 },
                new QuestionModel { ID = 54, DesignFactorID = 4, Question = "Business departments implementing their own information solutions with little or no involvement of the enterprise IT department (related to end-user computing, which often stems from dissatisfaction with IT solutions and services)", DefaultAnswer = 2 },
                new QuestionModel { ID = 55, DesignFactorID = 4, Question = "Ignorance of and/or noncompliance with privacy regulations", DefaultAnswer = 2 },
                new QuestionModel { ID = 56, DesignFactorID = 4, Question = "Inability to exploit new technologies or innovate using I&T", DefaultAnswer = 2 },
                ////
                new QuestionModel { ID = 57, DesignFactorID = 5, Question = "High", DefaultAnswer = 33 },
                new QuestionModel { ID = 58, DesignFactorID = 5, Question = "Normal", DefaultAnswer = 67 },
                ///
                new QuestionModel { ID = 59, DesignFactorID = 6, Question = "High compliance requirements", DefaultAnswer = 0 },
                new QuestionModel { ID = 60, DesignFactorID = 6, Question = "Normal compliance requirements", DefaultAnswer = 100 },
                new QuestionModel { ID = 61, DesignFactorID = 6, Question = "Low compliance requirements", DefaultAnswer = 0 },
                ///
                new QuestionModel { ID = 62, DesignFactorID = 7, Question = "Support", DefaultAnswer = 3 },
                new QuestionModel { ID = 63, DesignFactorID = 7, Question = "Factory", DefaultAnswer = 3 },
                new QuestionModel { ID = 64, DesignFactorID = 7, Question = "Turnaround", DefaultAnswer = 3 },
                new QuestionModel { ID = 65, DesignFactorID = 7, Question = "Strategic", DefaultAnswer = 3 },
                ///
                new QuestionModel { ID = 66, DesignFactorID = 8, Question = "Outsourcing", DefaultAnswer = 33 },
                new QuestionModel { ID = 67, DesignFactorID = 8, Question = "Cloud", DefaultAnswer = 33 },
                new QuestionModel { ID = 68, DesignFactorID = 8, Question = "Insourced", DefaultAnswer = 34 },
                ///
                new QuestionModel { ID = 69, DesignFactorID = 9, Question = "Agile", DefaultAnswer = 15 },
                new QuestionModel { ID = 70, DesignFactorID = 9, Question = "DevOps", DefaultAnswer = 10 },
                new QuestionModel { ID = 71, DesignFactorID = 9, Question = "Traditional", DefaultAnswer = 75 },
                ///
                new QuestionModel { ID = 72, DesignFactorID = 10, Question = "First mover", DefaultAnswer = 15 },
                new QuestionModel { ID = 73, DesignFactorID = 10, Question = "Follower", DefaultAnswer = 70 },
                new QuestionModel { ID = 74, DesignFactorID = 10, Question = "Slow adopter", DefaultAnswer = 15 }
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
                new ObjectiveModel { ID = 6, Name = "APO01", Code = "APO01", Description = "Manage the IT Management Framework" }
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
