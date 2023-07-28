using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<AuditModel> Audits { get; set; }
        public virtual ICollection<FocusAreaModel> FocusAreas { get; set; }
        public virtual ICollection<AuditScopeModel> AuditScopes { get; set; }
        public virtual ICollection<SubscriptionModel> Subscriptions { get; set; }
        public virtual ICollection<AuditMemberModel> AuditMembers { get; set; }
    }
}
