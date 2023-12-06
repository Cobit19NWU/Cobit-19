namespace Cobit_19.Shared.Dtos
{
    public class MapDto
    {
        public int QuestionID { get; set; }
        public int ObjectiveID { get; set; }
        public float Weight { get; set; } = default!;
        
        public QuestionDto Question { get; set; } = default!;
        public ObjectiveDto Objective { get; set; } = default!;

    }
}
