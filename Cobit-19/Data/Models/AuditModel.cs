using Cobit_19.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class AuditModel : AppModel<int>
    {
        public AuditModel()
        {
        }

        [ForeignKey("FocusAreas")]
        public int FocusAreaID { get; set; }
        public string ApplicationUserID { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        public AuditStatus Status { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; set; }

        public virtual FocusAreaModel FocusAreas { get; set; }
        public ICollection<AuditScopeModel> AuditScopes { get; set; }
        public ICollection<AnswerModel> Answers { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
