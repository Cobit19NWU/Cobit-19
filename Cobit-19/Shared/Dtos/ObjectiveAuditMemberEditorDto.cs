using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Shared.Dtos
{
    public class ObjectiveAuditMemberEditorDto
    {
        public int ObjectiveAuditID { get; set; }
        public string ApplicationUserID { get; set; }
    }
}
