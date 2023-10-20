namespace Cobit_19.Shared.Dtos
{
    public class ComponentQuestionDto
    {
        public string questionType { get; set; }
        public string questionDescription { get; set; }
        public int questionAnswer { get; set; }
        public double questionScore { get; set; }
        public string? questionComment { get; set; }
        public string? questionSkill { get; set; }
        public string? relatedGuidance { get; set; }
        public string? detailedReference { get; set; }
        public string? relevantPolicy { get; set; }
        public string? policyDescription { get; set; }
        public string? keyCultureElement { get; set; }

    }
}
