using AdvancedTask.Pages;
using AdvancedTask.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.AssertHelpers
{
    public class LoginAssertion:BaseClass
    {
        HomePage HomePageObj;

        public LoginAssertion()
        {
            HomePageObj = new HomePage();

        }


        public void AssertLoggedInUsernameSuccess()
        {

            string MessageText = HomePageObj.getFirstName();

            Assert.That( MessageText == "Hi Shilpi", "User is not loggedIn successfully");
                
           
           
        }
    }
}
