using AdvancedTask.Pages;
using AdvancedTask.Pages.Components.Sign_In;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Steps
{
    public class LoginSteps:BaseClass
    {
        
        LandingPage LandingPageObj;
        LoginComponent LoginComponentObj;

        public LoginSteps()
        {
            LandingPageObj = new LandingPage();
            LoginComponentObj = new LoginComponent();

        }


        public void DoLogin()
        {


            LandingPageObj.ClickSignInButton();
            Thread.Sleep(2000);

            LoginComponentObj.DoSignIn();

        }

    }
}
