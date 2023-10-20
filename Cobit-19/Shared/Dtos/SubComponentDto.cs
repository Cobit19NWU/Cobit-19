namespace Cobit_19.Shared.Dtos
{
    public class SubComponentDto
    {
        public string subComponentCode { get; set; }
        public string subComponentName { get; set; }
        public string subComponentDescription { get; set; }
        public List<SubComponentQuestionDto> subComponentQuestions { get; set; }
    }
}
