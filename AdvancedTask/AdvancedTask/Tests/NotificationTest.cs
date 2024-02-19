using AdvancedTask.Pages;
using AdvancedTask.Steps;
using AdvancedTask.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Tests
{
    [TestFixture]
    public class NotificationTest :BaseClass
    {
        LandingPage LandingPageObj;
        LoginSteps LoginStepsObj;
        NotificationSteps NotificationStepsObj;
        public NotificationTest()
        {
            LandingPageObj = new LandingPage();
            LoginStepsObj = new LoginSteps();
            NotificationStepsObj = new NotificationSteps();
        }

        [SetUp]

        public void SetUpNotificationTests()
        {
            Initialize();
            LoginStepsObj.DoLogin();

        }

        [Test, Order(1), Description("Verify that all notifications are loaded.")]
        public void VerifyNotificationSeeAll()
        {

            NotificationStepsObj.SeeAllClicked();
               
        }

        [Test, Order(2), Description("Verify that additional notifications are loaded.")]
        public void VerifyLoadMore()
        {
           
            NotificationStepsObj.LoadMoreClicked();
                
        }

        [Test, Order(3), Description("Verify that less notifications are loaded.")]
        public void VerifyShowLess()
        {

            NotificationStepsObj.ShowLessClicked();
        }

        [Test, Order(4), Description("Select All notifications")]
        public void VerifySelectAll()
        {
            
            NotificationStepsObj.SelectAlllicked();
                
        }

        [Test, Order(5), Description("Verify that notifications are unselected")]
        public void VerifyUnSelectAll()
        {
            
            NotificationStepsObj.UnselectAllClicked();
                
        }

        [Test, Order(6), Description("Verify that  notifications are Mark As Read")]
        public void VerifyMarkAsRead()
        {

            NotificationStepsObj.MarkAsReadlicked();
                
        }

        [Test, Order(7), Description("Verify that selected notifications are Deleted")]
        public void VerifyDelete()
        {
           
            NotificationStepsObj.DeleteSeletionClicked();
                
        }
    }
}
