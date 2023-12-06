using Cobit_19.Data.Models;
using Cobit_19.Shared.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Shared.Dtos
{
    public class ObjectiveAuditDto
    {
        public int ID { get; set; }
        public int AuditID { get; set; }
        public int ObjectiveID { get; set; }
        public string ApplicationUserID { get; set; } = default!;
        public bool Selected { get; set; } = default!;
        public AuditStatus Status { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public ObjectiveModel Objective { get; set; } = default!;
        public int ObjectiveScore { get; set; }
        public string? UserAuditObject { get; set; }
        public IList<ObjectiveAuditMemberDto> ObjectiveAuditMembers { get; set; } = default!;
    }
}
