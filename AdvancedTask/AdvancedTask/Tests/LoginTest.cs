using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;

namespace AdvancedTask.Tests
{

    public class LoginTest : BaseClass
    {
        LoginSteps LoginStepsObj;
        HomePageSteps HomePageStepsObj;

        public  LoginTest()
        {
            LoginStepsObj = new LoginSteps();
            HomePageStepsObj = new HomePageSteps();


        }



        [Test]
        public void LoginTestVerify()
        {
            Initialize();
            Thread.Sleep(1000);
            LoginStepsObj.DoLogin();

            HomePageStepsObj.ValidateIsLoggedIn();
        }
    }
}
