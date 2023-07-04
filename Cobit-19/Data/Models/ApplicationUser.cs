using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }
        public virtual ICollection<AuditModel> Audits { get; set; }
        public virtual ICollection<FocusAreaModel> FocusAreas { get; set; }
    }
}
