using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class DesignFactorModel : AppModel<int>
    {
        public DesignFactorModel()
        {
        }
        [ForeignKey("FocusArea")]
        public int FocusAreaID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Information { get; set; }

        public virtual FocusAreaModel FocusArea { get; set; }
        public virtual ICollection<QuestionModel> Questions { get; set; }
    }
}
