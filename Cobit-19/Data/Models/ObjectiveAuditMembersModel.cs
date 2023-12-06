using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class ObjectiveAuditMembersModel
    {
        public ObjectiveAuditMembersModel()
        {
        }

        [Key]
        [ForeignKey("ObjectiveAudit")]
        public int ObjectiveAuditID { get; set; }
        [Key]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual ObjectiveAuditModel ObjectiveAudit { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
