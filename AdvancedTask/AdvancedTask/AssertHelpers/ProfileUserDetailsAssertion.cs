using AdvancedTask.Pages.Components.ProfileOverview;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.AssertHelpers
{
    public class ProfileUserDetailsAssertion
    {

        ProfileUserDeatilsComponent ProfileUserDeatilsComponentObj;

        public ProfileUserDetailsAssertion()
        {
            ProfileUserDeatilsComponentObj = new ProfileUserDeatilsComponent();


        }

        public void AvailabilityAdded()
        {

           String Message= ProfileUserDeatilsComponentObj.GetMessageBoxText();
            Assert.That(Message ==  "Availability updated", "Availability has not been updated");

        }

        public void HoursAdded()
        {
            String Message = ProfileUserDeatilsComponentObj.GetMessageBoxText();
            Assert.That(Message == "Availability updated", "Hours has not been updated");
        }

        public void EarnTargetAdded()
        {
            String Message = ProfileUserDeatilsComponentObj.GetMessageBoxText();
            Assert.That(Message == "Availability updated", "EarnTarget has not been updated");
        }
    }

}
