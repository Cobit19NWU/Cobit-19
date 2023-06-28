using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Emit;

namespace Cobit_19.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
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
                new QuestionModel { ID = 1, DesignFactorID = 1, Question = "Growth/Acquisition" },
                new QuestionModel { ID = 2, DesignFactorID = 1, Question = "Innovation/Differentiation" },
                new QuestionModel { ID = 3, DesignFactorID = 1, Question = "Cost Leadership" },
                new QuestionModel { ID = 4, DesignFactorID = 1, Question = "Client Service/Stability" },
                ////
                new QuestionModel { ID = 5, DesignFactorID = 2, Question = "EG01—Portfolio of competitive products and services" },
                new QuestionModel { ID = 6, DesignFactorID = 2, Question = "EG02—Managed business risk" },
                new QuestionModel { ID = 7, DesignFactorID = 2, Question = "EG03—Compliance with external laws and regulations" },
                new QuestionModel { ID = 8, DesignFactorID = 2, Question = "EG04—Quality of financial information" },
                new QuestionModel { ID = 9, DesignFactorID = 2, Question = "EG05—Customer-oriented service culture" },
                new QuestionModel { ID = 10, DesignFactorID = 2, Question = "EG06—Business-service continuity and availability" },
                new QuestionModel { ID = 11, DesignFactorID = 2, Question = "EG07—Quality of management information" },
                new QuestionModel { ID = 12, DesignFactorID = 2, Question = "EG08—Optimization of internal business process functionality" },
                new QuestionModel { ID = 13, DesignFactorID = 2, Question = "EG09—Optimization of business process costs" },
                new QuestionModel { ID = 14, DesignFactorID = 2, Question = "EG10—Staff skills, motivation and productivity" },
                new QuestionModel { ID = 15, DesignFactorID = 2, Question = "EG11—Compliance with internal policies" },
                new QuestionModel { ID = 16, DesignFactorID = 2, Question = "EG12—Managed digital transformation programs" },
                new QuestionModel { ID = 17, DesignFactorID = 2, Question = "EG13—Product and business innovation" },
                ///
                new QuestionModel { ID = 18, DesignFactorID = 3, Question = "IT investment decision-making, portfolio definition & maintenance" },
                new QuestionModel { ID = 19, DesignFactorID = 3, Question = "Program & projects life cycle management" },
                new QuestionModel { ID = 20, DesignFactorID = 3, Question = "IT cost & oversight" },
                new QuestionModel { ID = 21, DesignFactorID = 3, Question = "IT expertise, skills & behaviour" },
                new QuestionModel { ID = 22, DesignFactorID = 3, Question = "Enterprise/IT architecture" },
                new QuestionModel { ID = 23, DesignFactorID = 3, Question = "IT operational infrastructure incidents" },
                new QuestionModel { ID = 24, DesignFactorID = 3, Question = "Unauthorized actions" },
                new QuestionModel { ID = 25, DesignFactorID = 3, Question = "Software adoption/usage problems" },
                new QuestionModel { ID = 26, DesignFactorID = 3, Question = "Hardware incidents" },
                new QuestionModel { ID = 27, DesignFactorID = 3, Question = "Software failures" },
                new QuestionModel { ID = 28, DesignFactorID = 3, Question = "Logical attacks (hacking, malware, etc.)" },
                new QuestionModel { ID = 29, DesignFactorID = 3, Question = "Third-party/supplier incidents" },
                new QuestionModel { ID = 30, DesignFactorID = 3, Question = "Noncompliance" },
                new QuestionModel { ID = 31, DesignFactorID = 3, Question = "Geopolitical Issues" },
                new QuestionModel { ID = 32, DesignFactorID = 3, Question = "Industrial action" },
                new QuestionModel { ID = 33, DesignFactorID = 3, Question = "Acts of nature" },
                new QuestionModel { ID = 34, DesignFactorID = 3, Question = "Technology-based innovation" },
                new QuestionModel { ID = 35, DesignFactorID = 3, Question = "Environmental" },
                new QuestionModel { ID = 36, DesignFactorID = 3, Question = "Data & information management" },
                ///
                new QuestionModel { ID = 37, DesignFactorID = 4, Question = "Frustration between different IT entities across the organization because of a perception of low contribution to business value" },
                new QuestionModel { ID = 38, DesignFactorID = 4, Question = "Frustration between business departments (i.e., the IT customer) and the IT department because of failed initiatives or a perception of low contribution to business value" },
                new QuestionModel { ID = 39, DesignFactorID = 4, Question = "Significant IT-related incidents, such as data loss, security breaches, project failure and application errors, linked to IT" },
                new QuestionModel { ID = 40, DesignFactorID = 4, Question = "Service delivery problems by the IT outsourcer(s)" },
                new QuestionModel { ID = 41, DesignFactorID = 4, Question = "Failures to meet IT-related regulatory or contractual requirements" },
                new QuestionModel { ID = 42, DesignFactorID = 4, Question = "Regular audit findings or other assessment reports about poor IT performance or reported IT quality or service problems" },
                new QuestionModel { ID = 43, DesignFactorID = 4, Question = "Substantial hidden and rogue IT spending, that is, IT spending by user departments outside the control of the normal IT investment decision mechanisms and approved budgets" },
                new QuestionModel { ID = 44, DesignFactorID = 4, Question = "Duplications or overlaps between various initiatives, or other forms of wasted resources" },
                new QuestionModel { ID = 45, DesignFactorID = 4, Question = "Insufficient IT resources, staff with inadequate skills or staff burnout/dissatisfaction" },
                new QuestionModel { ID = 46, DesignFactorID = 4, Question = "IT-enabled changes or projects frequently failing to meet business needs and delivered late or over budget" },
                new QuestionModel { ID = 47, DesignFactorID = 4, Question = "Reluctance by board members, executives or senior management to engage with IT, or a lack of committed business sponsorship for IT" },
                new QuestionModel { ID = 48, DesignFactorID = 4, Question = "Complex IT operating model and/or unclear decision mechanisms for IT-related decisions" },
                new QuestionModel { ID = 49, DesignFactorID = 4, Question = "Excessively high cost of IT" },
                new QuestionModel { ID = 50, DesignFactorID = 4, Question = "Obstructed or failed implementation of new initiatives or innovations caused by the current IT architecture and systems" },
                new QuestionModel { ID = 51, DesignFactorID = 4, Question = "Gap between business and technical knowledge, which leads to business users and information and/or technology specialists speaking different languages" },
                new QuestionModel { ID = 52, DesignFactorID = 4, Question = "Regular issues with data quality and integration of data across various sources" },
                new QuestionModel { ID = 53, DesignFactorID = 4, Question = "High level of end-user computing, creating (among other problems) a lack of oversight and quality control over the applications that are being developed and put in operation" },
                new QuestionModel { ID = 54, DesignFactorID = 4, Question = "Business departments implementing their own information solutions with little or no involvement of the enterprise IT department (related to end-user computing, which often stems from dissatisfaction with IT solutions and services)" },
                new QuestionModel { ID = 55, DesignFactorID = 4, Question = "Ignorance of and/or noncompliance with privacy regulations" },
                new QuestionModel { ID = 56, DesignFactorID = 4, Question = "Inability to exploit new technologies or innovate using I&T" },
                ////
                new QuestionModel { ID = 57, DesignFactorID = 5, Question = "High" },
                new QuestionModel { ID = 58, DesignFactorID = 5, Question = "Normal" },
                ///
                new QuestionModel { ID = 59, DesignFactorID = 6, Question = "High compliance requirements" },
                new QuestionModel { ID = 60, DesignFactorID = 6, Question = "Normal compliance requirements" },
                new QuestionModel { ID = 61, DesignFactorID = 6, Question = "Low compliance requirements" },
                ///
                new QuestionModel { ID = 62, DesignFactorID = 7, Question = "Support" },
                new QuestionModel { ID = 63, DesignFactorID = 7, Question = "Factory" },
                new QuestionModel { ID = 64, DesignFactorID = 7, Question = "Turnaround" },
                new QuestionModel { ID = 65, DesignFactorID = 7, Question = "Strategic" },
                ///
                new QuestionModel { ID = 66, DesignFactorID = 8, Question = "Outsourcing" },
                new QuestionModel { ID = 67, DesignFactorID = 8, Question = "Cloud" },
                new QuestionModel { ID = 68, DesignFactorID = 8, Question = "Insourced" },
                ///
                new QuestionModel { ID = 69, DesignFactorID = 9, Question = "Agile" },
                new QuestionModel { ID = 70, DesignFactorID = 9, Question = "DevOps" },
                new QuestionModel { ID = 71, DesignFactorID = 9, Question = "Traditional" },
                ///
                new QuestionModel { ID = 72, DesignFactorID = 10, Question = "First mover", },
                new QuestionModel { ID = 73, DesignFactorID = 10, Question = "Follower" },
                new QuestionModel { ID = 74, DesignFactorID = 10, Question = "Slow adopter" }
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
