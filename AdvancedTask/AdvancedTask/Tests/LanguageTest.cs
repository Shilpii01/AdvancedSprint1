using AdvancedTask.Pages;
using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;

namespace AdvancedTask.Tests
{
    [TestFixture]
    public class LanguageTest:BaseClass
    {
       
        LanguageSteps LanguageStepsObj;
        LoginSteps LoginStepsObj;
        HomePageSteps HomePageStepsObj;
       
        
        
        public LanguageTest()
        {
            
            LoginStepsObj = new LoginSteps();
            LanguageStepsObj = new LanguageSteps();
            HomePageStepsObj = new HomePageSteps();
           
        }

        [SetUp]
        public void SetUpLanguageTest()
        {
            Initialize();
            LoginStepsObj.DoLogin();
            //HomePageStepsObj.ClickOnLangaugesTab();
            LanguageStepsObj.LanguageStateReset();

        }

        [Test, Order(1), Description("Verify that a language can be added with valid data")]
        public void AddLanguagewithvalidData()
        {
           
            LanguageStepsObj.AddLanguageDetails();

         
        }

        [Test, Order(2), Description("Verify that a language can be added with Invalid data")]
        public void AddLanguagewithInvalidData()
        {

            LanguageStepsObj.AddInvalidLanguageDetails();

        }

        [Test, Order(3), Description("Verify that a language can be added with Destructive data")]
        public void AddLanguagewithDestructiveData()
        {


            LanguageStepsObj.AddDestructiveLanguageDetails();
        }

        [Test, Order(4), Description("Verify that a language can be updated with valid data.")]
        public void UpdateLanguageWithValidData()
        {
            LanguageStepsObj.AddLanguageDetails();
            LanguageStepsObj.UpdateLanguageDetails();
        }

       
        [Test, Order(5), Description("Verify that a language and its level can be deleted.")]
        public void DeleteLanguageLevel()
        {
            LanguageStepsObj.AddLanguageDetails();
            LanguageStepsObj.DeleteLanguageDetails();
        }



    }
}
