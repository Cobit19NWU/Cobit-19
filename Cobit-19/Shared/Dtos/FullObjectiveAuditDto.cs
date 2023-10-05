namespace Cobit_19.Shared.Dtos
{
    public class FullObjectiveAuditDto
    {
        public string objectiveName { get; set; }
        public string objectiveDescription { get; set; }
        public string objectivePurpose { get; set; }
        public string typeOfObjective { get; set; }
        public int maturityLevel { get; set; }
        public double maturityLevel0PercFinal { get; set; }
        public double maturityLevel1PercFinal { get; set; }
        public double maturityLevel2PercFinal { get; set; }
        public double maturityLevel3PercFinal { get; set; }
        public double maturityLevel4PercFinal { get; set; }
        public double maturityLevel5PercFinal { get; set; }
        public List<ComponentDto> components { get; set; }
    }
}
