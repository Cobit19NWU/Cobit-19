namespace Cobit_19.Business.Reports
{
    public class ObjectiveAuditData
    {
        public class AssesmentData
        {
            public string Organization { get; set; }
            public string Assessment { get; set; }
            public string Lead { get; set; }
            public string FocusArea { get; set; }
            public string Auditor { get; set; }
            public string AuditName { get; set; }
            public int Target { get; set; }
            public int Maturity { get; set; }
            public DateTime Date { get; set; }
        }

        public class Activities
        {
            public int Maturity { get; set; }
            public string Activity { get; set; }
            public int Importance { get; set; }
            public string Rating { get; set; }
        }
    }
}
