using AdvancedTask.Pages.Components.ProfileOverview;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.AssertHelpers
{
    public class NotificationAssertion
    {

        NotificationComponent NotificationComponentObj;
         
        public NotificationAssertion()
        {
            NotificationComponentObj = new NotificationComponent();
          
        }
        public void AssertNotificationSeeAll()
        {
            bool Message = NotificationComponentObj.SelectSeeAll();
            if (Message== true)
            {
                Assert.Pass("See All Button is Clicked ");
            }
            else
            {
                Assert.Fail("See All Button is not clicked");
            }
               
        }
        public void AssertLoadMore()
        {
            bool Message = NotificationComponentObj.SelectLoadMore();
            if (Message == true)
            {
                Assert.Pass("Load More Button is Clicked ");
            }
            else
            {
                Assert.Fail("Load More Button is not clicked");
            }
        }
        public void AssertShowLess()
        {
            Thread.Sleep(2000);
            bool Message = NotificationComponentObj.SelectShowLess();
            if (Message == true)
            {
                Assert.Pass("Show Less Button is Clicked ");
            }
            else
            {
                Assert.Fail("Show Less Button is not clicked");
            }
        }
        public void AssertSelectAll()
        {
            bool Message = NotificationComponentObj.SelectSelectAll();
            if (Message == true)
            {
                Assert.Pass("Select All Button is Clicked ");
            }
            else
            {
                Assert.Fail("Select All Button is not clicked");
            }
        }

        public void AssertUnselectAll()

        {
            bool Message = NotificationComponentObj.SelectUnselectAll();
            if (Message == true)
            {
                Assert.Pass("Unselect All Button is Clicked ");
            }
            else
            {
                Assert.Fail("Unselect All Button is not clicked");
            }
        }

        public void AssertMarkAsread()
        {
            bool Message = NotificationComponentObj.SelectMarkAsRead();
            if (Message == true)
            {
                Assert.Pass("Mark As Read Button is Clicked ");
            }
            else
            {
                Assert.Fail("Mark As Read Button is not clicked");
            }
        }

        public void AssertDeleteSelection()
        {
            bool Message = NotificationComponentObj.SelectDeleteSelectionButton();
            if (Message == true)
            {
                Assert.Pass("Delete Selection Button is Clicked ");
            }
            else
            {
                Assert.Fail("Delete Selection Button is not clicked");
            }
        }

    }
}
