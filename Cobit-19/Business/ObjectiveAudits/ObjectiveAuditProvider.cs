using AutoMapper;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cobit_19.Business.ObjectiveAudits
{
    public class ObjectiveAuditProvider
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private static readonly object _lock = new object();
        public ObjectiveAuditProvider(IMapper mapper, AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // Get objectiveAudits by audit id
        public IList<ObjectiveAuditDto> getAll(int auditId)
        {
            var quary = _dbContext.ObjectiveAudits
                .Where(a => a.AuditID == auditId)
                .Include(a => a.Objective)
                .ToList();

            return _mapper.Map<IList<ObjectiveAuditDto>>(quary);
        }

        // Get objectiveAudits by objectiveAudit id
        public ObjectiveAuditDto getByID(int objectiveAuditID)
        {
            var quary = _dbContext.ObjectiveAudits
                .Where(a => a.ID == objectiveAuditID)
                .Include(a => a.ObjectiveAuditMembers)
                .FirstOrDefault();

            return _mapper.Map<ObjectiveAuditDto>(quary);
        }

        // Get the members of the objectiveAudit
        public IList<ObjectiveAuditMemberDto> getMembersByObjectiveAuditID(int objectiveAuditID)
        {
            var quary = _dbContext.ObjectiveAuditMembers
                .Where(a => a.ObjectiveAuditID == objectiveAuditID)
                .Include(a => a.ApplicationUser)
                .ToList();

            return _mapper.Map<IList<ObjectiveAuditMemberDto>>(quary);
        }

        // Set selected objectiveAudits
        // TODO Implement status functionality
        public async Task<ObjectiveAuditDto> updateAsync(ObjectiveAuditEditorDto objectiveAuditEditor)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Find(objectiveAuditEditor.ID);

            if (objectiveAudit == null)
            {
                return null;
            }

            _mapper.Map(objectiveAuditEditor, objectiveAudit);

            if (objectiveAudit.Status == AuditStatus.InProgress)
            {
                objectiveAudit.DateCompleted = null;
            }
            else if (objectiveAudit.Status == AuditStatus.Completed)
            {
                objectiveAudit.DateCompleted = DateTime.Now;
            }

            _dbContext.ObjectiveAudits.Update(objectiveAudit);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ObjectiveAuditDto>(objectiveAudit);
        }

        // Determines of a user is a member of an objectiveAudit
        public bool isMember(ObjectiveAuditMemberEditorDto objectiveAuditMemberDto)
        {
            return _dbContext.ObjectiveAuditMembers.Any(a => 
                a.ObjectiveAuditID == objectiveAuditMemberDto.ObjectiveAuditID 
                && a.ApplicationUserID == objectiveAuditMemberDto.ApplicationUserID);
        }

        public async Task<ObjectiveAuditMemberDto> addMember(ObjectiveAuditMemberEditorDto memberEditorDto)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Find(memberEditorDto.ObjectiveAuditID);
            if (objectiveAudit == null)
            {
                return null;
            }

            var objectiveAuditMember = _mapper.Map<ObjectiveAuditMembersModel>(memberEditorDto);
            await _dbContext.ObjectiveAuditMembers.AddAsync(objectiveAuditMember);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<ObjectiveAuditMemberDto>(objectiveAuditMember); ;
        }

        public async Task<ObjectiveAuditMemberDto> deleteMember(ObjectiveAuditMemberEditorDto objectiveAuditMemberDto)
        {
            if (!isMember(objectiveAuditMemberDto))
            {
                return null;
            }

            var objectiveAuditMemberModel = _dbContext.ObjectiveAuditMembers.Where(a => a.ObjectiveAuditID == objectiveAuditMemberDto.ObjectiveAuditID && a.ApplicationUserID == objectiveAuditMemberDto.ApplicationUserID).First();

            _dbContext.ObjectiveAuditMembers.Remove(objectiveAuditMemberModel);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ObjectiveAuditMemberDto>(objectiveAuditMemberModel); ;
        }



        public string getAuditJSON(int objectiveAuditID)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Where(objAudit => objAudit.ID == objectiveAuditID).FirstOrDefault();

            var objectiveAuditJSON = objectiveAudit.UserAuditObject;

            return objectiveAuditJSON;
        }

        public void updateAuditJSON(int objectiveAuditID, string auditJSON)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.FirstOrDefault(objAudit => objAudit.ID == objectiveAuditID);

            if (objectiveAudit != null)
            {
                objectiveAudit.UserAuditObject = auditJSON;

                _dbContext.SaveChanges();
            }
        }

        public List<SubComponentDto> getSubComponents(ComponentDto component)
        {
            if (component.subComponents == null)
            {
                return null;
            }
            else
            {
                return component.subComponents;
            }

        }

        public ComponentDto getComponent(FullObjectiveAuditDto objectiveAudit,int componentID)
        {
            if (objectiveAudit.components[componentID] == null)
            {
                return null;
            }
            else
            {
                return objectiveAudit.components[componentID];
            }
        }

        public List<SubComponentQuestionDto> GetSubComponentMLevelQuestions(SubComponentDto subComp, string MLevelType = null)
        {
            var subCompQuestions = subComp.subComponentQuestions;
            List<SubComponentQuestionDto> MLevelQuestions = null;

            if (MLevelType != null)
            {
                var query = subCompQuestions.Where(question => question.questionType.Contains(MLevelType));
                MLevelQuestions = query.ToList();
            }
            else
            {
                var query = subCompQuestions.Where(question => question.questionType.Contains("Maturity Level"));
                MLevelQuestions = query.ToList();
            }

            if (MLevelQuestions != null && MLevelQuestions.Count > 0)
            {
                return MLevelQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<SubComponentQuestionDto> GetSubComponentInputQuestions(SubComponentDto subComp, string subCode = "None")
        {


            var SubCompQuestions = subComp.subComponentQuestions;

            var query = SubCompQuestions.Where(question => 
                question.questionType.Equals("Input"));

            var inputQuestions = query.ToList();

            if (inputQuestions.Count > 0)
            {
                return inputQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<SubComponentQuestionDto> GetSubComponentOutputQuestions(SubComponentDto subComp)
        {
            var SubCompQuestions = subComp.subComponentQuestions;

            var query = SubCompQuestions.Where(question =>
                question.questionType.Equals("Output"));

            var outputQuestions = query.ToList();

            if (outputQuestions.Count > 0)
            {
                return outputQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<SubComponentQuestionDto> GetSubComponentOutputQuestionsByCode(ComponentDto infoFlowComponents, string subCode)
        {
            var subComps = infoFlowComponents.subComponents;

            var selectedSubComp = subComps.Where(subComp => subComp.subComponentCode.Equals(subCode)).FirstOrDefault();

            if (selectedSubComp == null)
            {
                return null;
            }

            var subCompQuestions = selectedSubComp.subComponentQuestions;

            var query = subCompQuestions.Where(question =>
                question.questionType.Equals("Output"));

            var outputQuestions = query.ToList();

            if (outputQuestions.Count > 0)
            {
                return outputQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<SubComponentQuestionDto> GetSubComponentInputQuestionsByCode(ComponentDto infoFlowComponents, string subCode)
        {
            var subComps = infoFlowComponents.subComponents;

            var selectedSubComp = subComps.Where(subComp => subComp.subComponentCode.Equals(subCode)).FirstOrDefault();

            if (selectedSubComp == null)
            {
                return null;
            }
            var subCompQuestions = selectedSubComp.subComponentQuestions;

            var query = subCompQuestions.Where(question =>
                question.questionType.Equals("Input"));

            var outputQuestions = query.ToList();

            if (outputQuestions.Count > 0)
            {
                return outputQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<SubComponentQuestionDto> GetSubComponentRelatedGuidanceQuestions(SubComponentDto subComp)
        {
            var SubCompQuestions = subComp.subComponentQuestions;

            var query = SubCompQuestions.Where(question =>
                question.questionType.Equals("Related Guidance"));

            var relatedGuidanceQuestions = query.ToList();

            if (relatedGuidanceQuestions.Count > 0)
            {
                return relatedGuidanceQuestions; 
            }
            else
            {
                return null;
            }
        }

        public int GetAnswerAchievement(int answerValue)
        {
            if (answerValue <= 2)
            {
                return 0;
            }
            else if (answerValue > 2 && answerValue <= 5)
            {
                return 1;
            }
            else if (answerValue > 5 && answerValue <= 8)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public double calculateAnswerScore(int answerValue)
        {
            if (answerValue <= 2)
            {
                return Math.Round(answerValue * 0.075, 2);
            }
            else if (answerValue > 2 && answerValue <= 5)
            {
                return Math.Round(answerValue * 0.33, 2);
            }
            else if (answerValue > 5 && answerValue <= 8)
            {
                return Math.Round(answerValue * 0.68, 2);
            }
            else
            {
                return Math.Round(answerValue * 0.93, 2);
            }
        }

        public (int, double, int) calculateComponentScore(ComponentDto component, bool hasSubComps)
        {
            double finalPercentage;
            int answerValueSum = 0;
            double weightedValueSum = 0;

            if (hasSubComps == false)
            {
                var compQuestions = component.componentQuestions;
                foreach (ComponentQuestionDto compQuestion in compQuestions)
                {
                    answerValueSum += compQuestion.questionAnswer;
                    weightedValueSum += compQuestion.questionScore;
                }

                if (weightedValueSum == 0 || answerValueSum == 0)
                {
                    return ((answerValueSum, weightedValueSum, 0));
                }
                else
                {
                    finalPercentage = (weightedValueSum / answerValueSum) * 100;
                    return (answerValueSum, weightedValueSum, Convert.ToInt32(finalPercentage));
                }
            }
            else
            {
                var subComps = component.subComponents;

                foreach (var subComp in subComps)
                {
                    List<SubComponentQuestionDto> subCompQuestions = subComp.subComponentQuestions;

                    foreach (SubComponentQuestionDto subCompQuestion in subCompQuestions)
                    {
                        answerValueSum += subCompQuestion.questionAnswer;
                        weightedValueSum += subCompQuestion.questionScore;
                    }

                }

                if (weightedValueSum == 0 || answerValueSum == 0)
                {
                    return ((answerValueSum, weightedValueSum, 0));
                }
                else
                {
                    finalPercentage = (weightedValueSum / answerValueSum) * 100;
                    return (answerValueSum, weightedValueSum, Convert.ToInt32(finalPercentage));
                }
            }
        }

        public (int, double, double) calculateSubComponentScore(List<SubComponentQuestionDto> subCompQuestions)
        {
            double finalPercentage;
            int answerValueSum = 0;
            double weightedValueSum = 0;

            if (subCompQuestions == null)
            {
                return (0, 0, 0);
            }

            foreach (SubComponentQuestionDto subCompQuestion in subCompQuestions)
            {
                answerValueSum += subCompQuestion.questionAnswer;
                weightedValueSum += subCompQuestion.questionScore;
            }

            if (weightedValueSum == 0 || answerValueSum == 0)
            {
                return ((answerValueSum, weightedValueSum, 0));
            }
            else
            {
                finalPercentage = (weightedValueSum / answerValueSum) * 100;
                return (answerValueSum, weightedValueSum, Convert.ToInt32(finalPercentage));
            }
        }


        public Dictionary<string, double> calculateProcessSubComponentScores(SubComponentDto subComponent, ComponentDto infoFlowComponent)
        {
            List<SubComponentQuestionDto> subCompQuestions = subComponent.subComponentQuestions;
            List<SubComponentQuestionDto> inputQuestions = GetSubComponentInputQuestionsByCode(infoFlowComponent, subComponent.subComponentCode);
            List<SubComponentQuestionDto> outputQuestions = GetSubComponentOutputQuestionsByCode(infoFlowComponent, subComponent.subComponentCode);
            List<SubComponentQuestionDto> relatedGuidanceQuestions = GetSubComponentRelatedGuidanceQuestions(subComponent);

            (int inputAnswerVals, double inputWeightedVals, double inputfinalPerc) = calculateSubComponentScore(inputQuestions);
            (int outputAnswerVals, double outputWeightedVals, double outputfinalPerc) = calculateSubComponentScore(outputQuestions);
            (int RGAnswerVals, double RGWeightedVals, double RGfinalPerc) = calculateSubComponentScore(relatedGuidanceQuestions);

            List<string> MLevels = new List<string> { "Maturity Level 1", "Maturity Level 2", "Maturity Level 3", "Maturity Level 4", "Maturity Level 5" };
            Dictionary<string, double> MLevelPercs = new Dictionary<string, double>();

            foreach (string Mlevel in MLevels)
            {
                List<SubComponentQuestionDto> MLevelQuestions = GetSubComponentMLevelQuestions(subComponent, Mlevel);

                if (MLevelQuestions == null)
                {
                    MLevelPercs[Mlevel] = 0;
                }
                else
                {
                    (int MLevelAnswerVals, double MLevelWeightedVals, double MLevelfinalPerc) = calculateSubComponentScore(MLevelQuestions);

                    if (MLevelAnswerVals != 0)
                    {
                        int finalAnswerValues = MLevelAnswerVals + inputAnswerVals + outputAnswerVals + RGAnswerVals;
                        double finalWeightedValues = MLevelWeightedVals + inputWeightedVals + outputWeightedVals + RGWeightedVals;
                        double finalMLevelPerc = Math.Round((finalWeightedValues / finalAnswerValues) * 100, 2);
                        MLevelPercs[Mlevel] = finalMLevelPerc;
                    }
                    else
                    {
                        MLevelPercs[Mlevel] = 0;
                    }
                }
            }

            return MLevelPercs;
        }

        public int calculateFinalProcessComponentScore(ComponentDto processComp, ComponentDto infoFlowComp)
        {
            List<SubComponentDto> subComps = processComp.subComponents;
            int valueCount = 0;
            double maturityLevelSum = 0;

            foreach (SubComponentDto subComp in subComps)
            {
                Dictionary<string, double> MLevelPercs = calculateProcessSubComponentScores(subComp, infoFlowComp);

                foreach (var kvp in MLevelPercs)
                {
                    if (kvp.Value != 0)
                    {
                        valueCount++;
                        maturityLevelSum += kvp.Value;
                    }
                }
            }

            return Convert.ToInt32(maturityLevelSum / valueCount);
        }

        public double calculateFinalMaturityLevelPercs(FullObjectiveAuditDto fullAudit, string MLevel)
        {
            ComponentDto processComp = fullAudit.components[2];
            ComponentDto infoFlowComp = fullAudit.components[4];
            List<SubComponentDto> processSubComps = processComp.subComponents;
            int valueCount = 0;
            double maturityLevelSum = 0;

            foreach (SubComponentDto subComp in processSubComps)
            {
                var MLevelPercs = calculateProcessSubComponentScores(subComp, infoFlowComp);

                foreach (var kvp in MLevelPercs)
                {
                    if (kvp.Key == MLevel)
                    {
                        maturityLevelSum += kvp.Value;
                    }
                }
            }
            
            foreach (ComponentDto component in fullAudit.components)
            {
                if (component.componentName != "A")
                {
                    maturityLevelSum += component.componentPercFinal;
                    valueCount++;
                }
            }

            double finalMaturityPerc = maturityLevelSum / valueCount;

            return Math.Round(finalMaturityPerc, 2);
        }

        public int CalculateFinalMaturityLevel(FullObjectiveAuditDto fullAudit)
        {
            double level1Perc = fullAudit.maturityLevel1PercFinal;
            double level2Perc = fullAudit.maturityLevel2PercFinal;
            double level3Perc = fullAudit.maturityLevel3PercFinal;
            double level4Perc = fullAudit.maturityLevel4PercFinal;
            double level5Perc = fullAudit.maturityLevel5PercFinal;

            if (level1Perc > 0.93 &&
                level2Perc > 0.93 &&
                level3Perc > 0.93 &&
                level4Perc > 0.93 &&
                level5Perc > 0.5)
            {
                return 5; // Maturity Level 5
            }
            else if (level1Perc > 0.93 &&
                     level2Perc > 0.93 &&
                     level3Perc > 0.93 &&
                     level4Perc > 0.5)
            {
                return 4; // Maturity Level 4
            }
            else if (level1Perc > 0.93 &&
                     level2Perc > 0.93 &&
                     level3Perc > 0.5)
            {
                return 3; // Maturity Level 3
            }
            else if (level1Perc > 0.5 &&
                     level2Perc > 0.5 &&
                     level3Perc > 0.5 &&
                     level4Perc > 0.5)
            {
                return 2; // Maturity Level 2
            }
            else if (level1Perc <= 0.5 ||
                     level2Perc <= 0.5)
            {
                return 1; // Maturity Level 1
            }
            else
            {
                return 0; // Default if no conditions are met
            }
        }
    }
}
