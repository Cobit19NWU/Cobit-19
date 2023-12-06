namespace Cobit_19.Shared.Dtos
{
    public class QuestionDto
    { 
        public int ID { get; set; }
        public string Question { get; set; } = default!;
        public IList<AnswerDto> Answers { get; set; } = default!;
        public int BaseAnswer { get; set; } = default!;
        public int AnswerRange { get; set; } = default!;
        public int Odds { get; set; } = default!;
        public IList<MapDto>? Maps { get; set; } = default!;
    }
}
