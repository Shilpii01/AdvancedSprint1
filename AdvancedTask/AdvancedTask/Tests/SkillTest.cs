using AdvancedTask.Pages;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdvancedTask.Tests
{
    [TestFixture]
    public class SkillTest : BaseClass
    {

        
        ProfileTabComponents ProfileTabComponentsObj;
        SkillSteps SkillStepsObj;
        LoginSteps LoginStepsObj;
        HomePageSteps HomePageStepsObj;



        public SkillTest()
        {
            
            LoginStepsObj = new LoginSteps();
            SkillStepsObj = new SkillSteps();
            HomePageStepsObj = new HomePageSteps();

        }

        [SetUp]
        public void SetUpCertificateTest()
        {
            Initialize();           
            LoginStepsObj.DoLogin();
            Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            SkillTab.Click();
           SkillStepsObj.SkillStateReset();


        }
        [Test, Order(1), Description("Verify that a Skill can be added with valid data")]
        public void AddSkillWithValidData()
        {
           // HomePageStepsObj.ClickOnSkillsTab();
            SkillStepsObj.AddSkillDetails();
        }
        [Test, Order(2), Description("Verify that a Skill can be added with Invalid data")]
        public void AddSkillWithInvalidData()
        {
            SkillStepsObj.AddInvalidSkillDetails();

        }
        [Test, Order(3), Description("Verify that a Skill can be added with Destrutive data")]
        public void AddSkillWithDestructiveData()
        {
            SkillStepsObj.AddDestructiveSkillDetails();

        }

        [Test, Order(4), Description("Verify that a skill can be updated with valid data.")]
        public void UpdateSkillTest()
        {
            SkillStepsObj.AddSkillDetails();
            SkillStepsObj.UpdateSkillDetails();
        }


        [Test, Order(5), Description("Verify that a skill and its level can be deleted.")]
        public void DeleteSkillTest()
        {
            SkillStepsObj.AddSkillDetails();
            SkillStepsObj.DeleteSkillDetails();
        }
    }
}