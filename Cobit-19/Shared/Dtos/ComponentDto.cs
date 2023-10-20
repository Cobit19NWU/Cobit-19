namespace Cobit_19.Shared.Dtos
{
    public class ComponentDto
    {
        public string componentName { get; set; }
        public string componentDescription { get; set; }
        public int componentPercFinal { get; set; }
        public List<SubComponentDto>? subComponents { get; set; }
        public List<ComponentQuestionDto>? componentQuestions { get; set; }
    }
}
