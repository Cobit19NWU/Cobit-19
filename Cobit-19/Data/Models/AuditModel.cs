using Cobit_19.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class AuditModel : AppModel<int>
    {
        public AuditModel()
        {
        }
        [ForeignKey("FocusAreas")]
        public int FocusAreaID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        public AuditStatus Status { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateCompleted { get; set; }

        public virtual FocusAreaModel FocusArea { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<AuditScopeModel> AuditScopes { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; set; }
        public virtual ICollection<AuditMemberModel> AuditMembers { get; set; }

    }
}
