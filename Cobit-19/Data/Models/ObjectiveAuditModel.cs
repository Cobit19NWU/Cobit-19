using Cobit_19.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class ObjectiveAuditModel : AppModel<int>
    {
        public ObjectiveAuditModel()
        {
        }
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public bool Selected { get; set; }
        public AuditStatus Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? UserAuditObject { get; set; }

        public virtual AuditModel Audit { get; set; }
        public virtual ObjectiveModel Objective { get; set; }
        public virtual ICollection<ObjectiveAuditMembersModel> ObjectiveAuditMembers { get; set; }
    }
}
