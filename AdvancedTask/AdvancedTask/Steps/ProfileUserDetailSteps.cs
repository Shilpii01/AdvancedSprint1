using AdvancedTask.AssertHelpers;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Steps
{
    public class ProfileUserDetailSteps : BaseClass
    {

        ProfileUserDeatilsComponent ProfileUserDetailsComponentObj;
        ProfileTabComponents ProfileTabComponentsObj;
        ProfileUserDetailsAssertion ProfileUserDetailsAssertionObj;



        public ProfileUserDetailSteps()
        {
            ProfileUserDetailsComponentObj = new ProfileUserDeatilsComponent();
            ProfileTabComponentsObj = new ProfileTabComponents();
            ProfileUserDetailsAssertionObj = new ProfileUserDetailsAssertion();
        }


        public void AddAvailabilityData()
        {
            List<ProfileData> AvailabilityDetails = JsonReader.ReadTestDataFromJson<ProfileData>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddAvailability.json");


            ProfileUserDetailsComponentObj.AddAvailability(AvailabilityDetails[0].Availability);
            ProfileUserDetailsAssertionObj.AvailabilityAdded();

        }
        public void AddHoursData()
        {
            List<ProfileData> HoursDetails = JsonReader.ReadTestDataFromJson<ProfileData>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddHours.json");


            ProfileUserDetailsComponentObj.AddHours(HoursDetails[0].Hours);
            ProfileUserDetailsAssertionObj.HoursAdded();
        }
        public void AddEarnTargetData()
        {
            List<ProfileData> EarnTargetDetails = JsonReader.ReadTestDataFromJson<ProfileData>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddEarnTarget.json");



            ProfileUserDetailsComponentObj.AddEarnTarget(EarnTargetDetails[1].EarnTarget);
            ProfileUserDetailsAssertionObj.EarnTargetAdded();



        }

    }
}
