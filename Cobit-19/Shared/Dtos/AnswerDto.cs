namespace Cobit_19.Shared.Dtos
{
    public class AnswerDto
    {
        public int AuditId { get; set; } = default!;
        public int QuestionId { get; set; } = default!;
        public int Answer { get; set; } = default!;
        public int AnswerRange { get; set; } = default!;
        public int Odds { get; set; } = default!;
    }
}
