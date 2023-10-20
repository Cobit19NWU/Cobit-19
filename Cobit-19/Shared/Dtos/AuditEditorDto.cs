using Cobit_19.Shared.Enums;

namespace Cobit_19.Shared.Dtos
{
    public class AuditEditorDto
    {
        public int ID { get; set; }
        public int FocusAreaID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; } = default!;
        public AuditStatus Status { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
