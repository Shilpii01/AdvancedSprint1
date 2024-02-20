using AdvancedTask.Pages;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;

namespace AdvancedTask.Tests
{
    [TestFixture]
    public class SearchSkillTest :BaseClass
    {
        LandingPage LandingPageObj;
        LoginSteps LoginStepsObj;
        SearchSkillSteps SearchSkillStepsObj;
        ProfileTabComponents ProfileTabComponentsObj;
        public SearchSkillTest()
        {
            LandingPageObj = new LandingPage();
            LoginStepsObj = new LoginSteps();
            SearchSkillStepsObj = new SearchSkillSteps();
            ProfileTabComponentsObj = new ProfileTabComponents();
            
        }

        [SetUp]
        public void SetUpSearchSkillTests()
        {
            Initialize();
            LoginStepsObj.DoLogin();
          

        }

        [Test, Order(1), Description("Verify User is able to Search by a valid Skill Name")]
        public void SearchSkillByValidData()
        {
            SearchSkillStepsObj.SearchBySkill();
        }

        [Test, Order(2), Description("Verify User able to Search by Invalid Skill Name")]
        public void SearchSkillByInvalidData()
        {

            SearchSkillStepsObj.SearchByInvalidSkill();
        }


        [Test, Order(3), Description("Verify User able to Search by Username")]
        public void SearchSkillByUserDetails()
        {
            
            SearchSkillStepsObj.SearchByUserName();
        }

        [Test, Order(4), Description("Verify User is able to Search by Category")]
        public void SearchSkillByCategory()
        {
           
            SearchSkillStepsObj.SearchByCategoryclicked();
        }

        [Test, Order(5), Description("Verify User able to Search through Filter option")]
        public void SearchSkillByFilter()
        {
            SearchSkillStepsObj.SearchByFilterclicked();
        }

    }
}
