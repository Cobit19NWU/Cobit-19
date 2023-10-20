using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class MapModel
    {
        public MapModel()
        {
        }
        [Key]
        [ForeignKey("Question")]
        public int QuestionID { get; set; }
        [Key]
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        [Required]
        public float Weight { get; set; }

        public virtual QuestionModel Question { get; set; }
        public virtual ObjectiveModel Objective { get; set; }

    }
}
