using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    [PrimaryKey(nameof(ApplicationUserID), nameof(AuditID))]
    public class AuditMemberModel
    {
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        [ForeignKey("AuditModel")]
        public int AuditID { get; set; }

        public virtual AuditModel Audit { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
