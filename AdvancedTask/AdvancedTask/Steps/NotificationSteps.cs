using AdvancedTask.AssertHelpers;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Steps
{
    public class NotificationSteps : BaseClass
    {
        NotificationComponent NotificationComponentObj;
        ProfileTabComponents ProfileTabComponentsObj;
        NotificationAssertion NotificationAssertionObj;
        public NotificationSteps()
        {
            NotificationComponentObj = new NotificationComponent();
            ProfileTabComponentsObj = new ProfileTabComponents();
            NotificationAssertionObj = new NotificationAssertion();
        }
        public void SeeAllClicked()
        {

            ProfileTabComponentsObj.ClickNotificationTab();

            bool SeeAllButtonClicked = NotificationComponentObj.SelectSeeAll();
            NotificationAssertionObj.AssertNotificationSeeAll();

        }
        public void LoadMoreClicked()
        {
            ProfileTabComponentsObj.ClickDashboard();

            bool LoadMoreButtonClicked = NotificationComponentObj.SelectLoadMore();
            Thread.Sleep(3000);
            NotificationAssertionObj.AssertLoadMore();
        }
        public void ShowLessClicked()
        {

            ProfileTabComponentsObj.ClickDashboard();
            bool ShowLessButtonClicked = NotificationComponentObj.SelectShowLess();
            Thread.Sleep(3000);
            NotificationAssertionObj.AssertShowLess();


        }
        public void SelectAlllicked()
        {
            ProfileTabComponentsObj.ClickDashboard();
            bool AllNotificationSelected = NotificationComponentObj.SelectSelectAll();
            Thread.Sleep(3000);
            NotificationAssertionObj.AssertSelectAll();

        }
        public void UnselectAllClicked()
        {
            ProfileTabComponentsObj.ClickDashboard();
            bool AllNotificationUnselected = NotificationComponentObj.SelectUnselectAll();
            Thread.Sleep(3000);
            NotificationAssertionObj.AssertUnselectAll();

        }
        public void MarkAsReadlicked()
        {
            ProfileTabComponentsObj.ClickDashboard();
            bool MarkedSelectionAsRead = NotificationComponentObj.SelectMarkAsRead();
            string Message = NotificationComponentObj.GetMessageBoxText();

            NotificationAssertionObj.AssertMarkAsread();

        }
        public void DeleteSeletionClicked()
        {
            ProfileTabComponentsObj.ClickDashboard();
            bool SelectNotificationDeleted = NotificationComponentObj.SelectDeleteSelectionButton();
            string Message = NotificationComponentObj.GetMessageBoxText();

            NotificationAssertionObj.AssertDeleteSelection();

        }
    }
}
