using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class AuditScopeModel
    {
        [Key]
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [Key]
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        public string UserID { get; set; }

        public AuditModel Audit { get; set; }
        public ObjectiveModel Objective { get; set; }
    }
}
