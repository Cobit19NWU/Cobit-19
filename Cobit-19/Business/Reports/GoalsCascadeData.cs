namespace Cobit_19.Business.Reports
{
    public class GoalsCascadeData
    {
        public class AssesmentData
        {
            public string Organization { get; set; }
            public string Assessment { get; set; }
            public string Lead { get; set; }
            public string FocusArea { get; set; }
            public int Maturity { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
