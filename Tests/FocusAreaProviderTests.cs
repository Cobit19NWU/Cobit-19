using AutoMapper;
using Cobit_19.Business.FocusAreas;
using Cobit_19.Shared.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing;

namespace Tests
{
    public class FocusAreaProviderTests : IClassFixture<TestDatabaseFixture>
    {
        private readonly TestDatabaseFixture _fixture;
        private FocusAreaProvider _focusAreaProvider;
        private IMapper _mapper;

        public FocusAreaProviderTests(TestDatabaseFixture fixture)
        {
            _fixture = fixture;

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

            _focusAreaProvider = new FocusAreaProvider(_mapper, _fixture.CreateContext());
        }

        [Fact]
        public void GetAllAuditsForFocusArea_ShouldReturnValue()
        {
            //Act
            var result = _focusAreaProvider.GetAllAuditsForFocusArea(1);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAuditsForFocusAreaByUserID_ShouldReturnValue()
        {
            //Act
            var result = _focusAreaProvider.GetAuditsForFocusAreaByUserID("8e445865-a24d-4543-a6c6-9443d048cdb9", 1);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFocusAreasByUserID_ShouldReturnValue()
        {
            //Act
            var result = _focusAreaProvider.GetFocusAreasByUserID("8e445865-a24d-4543-a6c6-9443d048cdb9");

            //Assert
            Assert.NotNull(result);
        }
    }
}
