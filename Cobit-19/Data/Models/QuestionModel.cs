using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class QuestionModel : AppModel<int>
    {
        public QuestionModel()
        {
        }
        [ForeignKey("DesignFactor")]
        public int DesignFactorID { get; set; }
        [Required]
        public string Question { get; set; } = default!;
        public int BaseAnswer { get; set; } = default!;
        public int AnswerRange { get; set; } = default!;
        public int Odds { get; set; } = default!;

        public virtual DesignFactorModel DesignFactor { get; set; }
        public virtual ICollection<MapModel> Maps { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; set; }
    }
}
