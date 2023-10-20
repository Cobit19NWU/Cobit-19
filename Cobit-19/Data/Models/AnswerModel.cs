using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class AnswerModel
    {
        public AnswerModel()
        {
        }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Question")]
        public int QuestionID { get; set; }
        [DefaultValue(0)]
        public int Answer { get; set; }
        public int AnswerRange { get; set; }
        [DefaultValue(null)]
        public int Odds { get; set; }
        public virtual AuditModel Audit { get; set; }
        public virtual QuestionModel Question { get; set; }
    }
}
