using AdvancedTask.Pages;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;

namespace AdvancedTask.Tests
{
    [TestFixture]
    public class ProfileUserDetailsTest : BaseClass
    {
        LandingPage LandingPageObj;
        LoginSteps LoginStepsObj;
        ProfileUserDetailSteps ProfileUserDetailStepsObj;
        ProfileTabComponents ProfileTabComponentsObj;
        public ProfileUserDetailsTest()
        {
            LandingPageObj = new LandingPage();
            LoginStepsObj = new LoginSteps();
            ProfileUserDetailStepsObj = new ProfileUserDetailSteps();           
            ProfileTabComponentsObj = new ProfileTabComponents();
        }

        [SetUp]

        public void SetupNotificationtests()
        {
            Initialize();
            LoginStepsObj.DoLogin();
           

        }
       

        [Test, Order(1), Description("Verify that user Availability Status can be changed.")]
        public void addAvailability()
        {
           ProfileTabComponentsObj.ClickAvailabilityIcon();
            ProfileUserDetailStepsObj.AddAvailabilityData();
           
        }

        [Test, Order(2), Description("Verify that user Hours Status can be changed.")]
        public void addHours()
        {
            ProfileTabComponentsObj.ClickHoursIcon();
            ProfileUserDetailStepsObj.AddHoursData();   
               
        }

        [Test, Order(3), Description("Verify that user $Earn Target Status can be changed.")]
        public void addTarget()
        {
            ProfileTabComponentsObj.ClickEarnTargetIcon();
            ProfileUserDetailStepsObj.AddEarnTargetData();
               
        }
    }
}
