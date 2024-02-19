using AdvancedTask.Pages;
using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;

namespace AdvancedTask.Tests
{
    [TestFixture]
    public class ShareSkillTest : BaseClass
    {
        LandingPage LandingPageObj;
        LoginSteps LoginStepsObj;     
        ShareSkillSteps ShareSkillStepsObj;
       

        public ShareSkillTest()
        {
            LandingPageObj = new LandingPage();
            LoginStepsObj = new LoginSteps();
            ShareSkillStepsObj = new ShareSkillSteps();
          
        }

        [SetUp]

        public void SetUpShareSkillTests()
        {
            Initialize();
            LoginStepsObj.DoLogin();
            //ShareSkillStepsObj.DeleteShareSkill();

        }

        [Test, Order(1), Description("Verify that user can add a valid shareSkill .")]
        public void AddShareSkillWithValidData()
        {
           
            ShareSkillStepsObj.AddShareSkill();
        }

        [Test, Order(2), Description("Verify that user can add an Invalid shareSkill .")]
        public void AddShareSkillWithInvalidData()
        {
            ShareSkillStepsObj.AddInvalidShareSkill();

        }

        [Test, Order(3), Description("Verify that user can add a Destructive shareSkill .")]
        public void AddShareSkillWithDestructiveData()
        {
            ShareSkillStepsObj.AddDestructiveShareSkill();
                

        }

       

        [Test, Order(4), Description("Verify that user can update a ShareSkill using Valid data.")]
        public void UpdateShareSkillTest()
        {
         
            ShareSkillStepsObj.AddShareSkill();
            ShareSkillStepsObj.UpdateShareSkill();        
        }

        
        [Test, Order(3), Description("Verify that user can delete a ShareSkill.")]
        public void DeleteShareSkillTest()
        {
           
            ShareSkillStepsObj.AddShareSkill();
            ShareSkillStepsObj.DeleteShareSkill();
        }
    }
}
