﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class FocusAreaModel : AppModel<int>
    {
        public FocusAreaModel()
        {
        }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<AuditModel> Audits { get; set; }
        public virtual ICollection<DesignFactorModel> DesignFactors { get; set; }
        public virtual ICollection<ObjectiveAuditTemplateModel> ObjectiveAuditTemplates { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<SubscriptionModel> Subscriptions { get; set; }
    }
}
