using AdvancedTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages
{
    public class LandingPage: BaseClass
    {
        private IWebElement signInButton; 


        public void renderComponents()
        {
            try
            {
                signInButton= driver.FindElement(By.XPath("//*[text()='Sign In']")); 
                   

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void ClickSignInButton()
        {

            renderComponents();
            Thread.Sleep(2000);
            signInButton.Click();

        }



    }
}
