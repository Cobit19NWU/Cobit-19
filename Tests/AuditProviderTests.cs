using AutoMapper;
using Cobit_19.Business.Audits;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Cobit_19.Shared.Profiles;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;

namespace Testing
{
    public class AuditProviderTests : IClassFixture<TestDatabaseFixture>
    {
        private readonly TestDatabaseFixture _fixture;
        private AuditProvider _auditProvider;
        private IMapper _mapper;

        public AuditProviderTests(TestDatabaseFixture testDatabaseFixture)
        {
            _fixture = testDatabaseFixture;

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AuditProfile());
                mc.AddProfile(new FocusAreaProfile());
                mc.AddProfile(new DesignFactorProfile());
                mc.AddProfile(new QuestionProfile());
                mc.AddProfile(new AnswerProfile());
                mc.AddProfile(new MapProfile());
                mc.AddProfile(new ObjectiveProfile());
                mc.AddProfile(new UserProfile());
            });
            _mapper = mapperConfig.CreateMapper();
            
            
        }

        [Fact]
        public async Task GetAuditTest()
        {
            // Act
            var result = await _auditProvider.getAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result.FocusArea.DesignFactors.First().Questions);

            // Act
            var x = await _auditProvider.getAsync(999);

            // Assert
            Assert.Null(x);
            
        }

        [Fact]
        public async Task GetDesignFactorsTest()
        {
            // Act
            var result = await _auditProvider.getDesignFactorsAsync(1);

            // Assert
            Assert.NotEmpty(result);
            Assert.True(result.First().Questions.Count() == 4);

            // Act
            result = await _auditProvider.getDesignFactorsAsync(999);

            // Assert
            Assert.True(result.Count() == 0);
        }

        [Fact]
        public async Task GetDesignFactorTest()
        {
            // Act
            var result = await _auditProvider.getDesignFactorFullAsync(1, 1);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result.Questions);
            Assert.True(result.Questions.First().Maps.Count() == 40);

            // Act
            result = await _auditProvider.getDesignFactorFullAsync(1, 99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task CreateAuditTest()
        {
            // Act
            var newAudit = new AuditEditorDto
            {
                Name = "Test Audit",
                FocusAreaID = 1,
                UserID = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Status = AuditStatus.InProgress,
                DateCreated = DateTime.Now
            };

            var audit = await _auditProvider.createAsync(newAudit);

            var dbAudit = await _auditProvider.getAsync(audit.ID);
            var DF = await _auditProvider.getDesignFactorsAsync(audit.ID);

            var answers = DF.Select(q => q.Questions.Select(a => a.Answers));

            // Assert
            Assert.NotNull(dbAudit);  
            Assert.NotEmpty(answers); 
        }

        [Fact]
        public async Task DeleteAuditTest()
        {
            // Act
            var newAudit = new AuditEditorDto
            {
                Name = "Delete Audit",
                FocusAreaID = 1,
                UserID = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Status = AuditStatus.InProgress,
                DateCreated = DateTime.Now
            };

            var audit = await _auditProvider.createAsync(newAudit);

            // Assert
            Assert.NotNull(audit);

            //Act
            await _auditProvider.deleteAsync(audit.ID);
            // Assert
            Assert.Null(await _auditProvider.getAsync(audit.ID));           
            Assert.Empty(await _auditProvider.getDesignFactorsAsync(audit.ID));

            //Act
            var falseDel = await _auditProvider.deleteAsync(999);
            // Assert
            Assert.Null(falseDel);
        }

        [Fact]
        public async Task UpdateAuditTest()
        {
            // Create a new Audit
            var newAudit = new AuditEditorDto
            {
                Name = "Update Audit",
                FocusAreaID = 1,
                UserID = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Status = AuditStatus.InProgress,
                DateCreated = DateTime.Now
            };

            var audit = await _auditProvider.createAsync(newAudit);

            // Assert
            Assert.NotNull(audit);         

            // Act
            var edt = new AuditEditorDto() 
            {
                ID = audit.ID,
                Name = "Working Audit",
                FocusAreaID = 1,
                UserID = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Status = AuditStatus.Completed,
                DateCreated = DateTime.Now
            };

            await _auditProvider.updateAsync(edt);

            // Assert
            Assert.Equal("Working Audit", (await _auditProvider.getAsync(audit.ID)).Name);           

            // Act
            await _auditProvider.deleteAsync(audit.ID);

            // Assert
            Assert.Null(await _auditProvider.getAsync(audit.ID));
            Assert.Empty(await _auditProvider.getDesignFactorsAsync(audit.ID)); 
        }
    }
}