using System.ComponentModel.DataAnnotations;

namespace Cobit_19.Data.Models
{
    public class ObjectiveModel : AppModel<int>
    {
        public ObjectiveModel()
        {
        }
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<MapModel> Maps { get; set; }
        public virtual ICollection<ObjectiveAuditModel> ObjectiveAudits { get; set; }
        public virtual ICollection<ObjectiveAuditTemplateModel> ObjectiveAuditTemplates { get; set; }
    }
}
