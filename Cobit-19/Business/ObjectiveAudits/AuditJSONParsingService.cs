using Newtonsoft.Json;
using Cobit_19.Shared.Dtos;

namespace Cobit_19.Business.ObjectiveAudits
{
    public class AuditJSONParsingService
    {
        public static FullObjectiveAuditDto parseAuditTemplate (string jsonTemplate)
        {
            FullObjectiveAuditDto objectiveAudit = JsonConvert.DeserializeObject<FullObjectiveAuditDto>(jsonTemplate);
            return objectiveAudit;
        }

        public static string auditTemplateSerializer (FullObjectiveAuditDto objectiveAudit)
        {
            string objectiveAuditJSONString = JsonConvert.SerializeObject(objectiveAudit);
            return objectiveAuditJSONString;
        }
    }
}
