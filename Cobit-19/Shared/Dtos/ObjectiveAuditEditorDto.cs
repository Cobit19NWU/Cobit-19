using Cobit_19.Data.Models;
using Cobit_19.Shared.Enums;

namespace Cobit_19.Shared.Dtos
{
    public class ObjectiveAuditEditorDto
    {
        public int ID { get; set; }
        public string ApplicationUserID { get; set; } = default!;
        public bool Selected { get; set; } = default!;
        public AuditStatus Status { get; set; } = default!;
        public DateTime? DateCompleted { get; set; }
    }
}
