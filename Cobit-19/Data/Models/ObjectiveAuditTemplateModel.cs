using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class ObjectiveAuditTemplateModel
    {
        public ObjectiveAuditTemplateModel()
        {
        }
        [Key]
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        [ForeignKey("FocusArea")]
        public int FocusAreaID { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string AuditObject { get; set; }

        public virtual ObjectiveModel Objective { get; set; }
        public virtual FocusAreaModel FocusArea { get; set; }
    }
}
