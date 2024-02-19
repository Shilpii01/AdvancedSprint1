using AdvancedTask.Pages;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Steps
{
    public class HomePageSteps:BaseClass
    {
        private HomePage homePageObj;
        private ProfileTabComponents profileTabComponentsObj;

        public HomePageSteps()
        {
            homePageObj = new HomePage();
            profileTabComponentsObj = homePageObj.getProfileTabComponents();
        }


        public void ClickOnLangaugesTab()
        {
            profileTabComponentsObj.ClickLangaugesTab();
        }


        public void ClickOnSkillsTab()
        {
            profileTabComponentsObj.ClickSkillsTab();
        }

        public void ValidateIsLoggedIn()
        {
            homePageObj.getFirstName();

        }
    }
}
