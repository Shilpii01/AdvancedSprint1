using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.Sign_In
{
    public class LoginComponent:BaseClass

    {

        private IWebElement EmailTextbox;
        private IWebElement PasswordTextbox;
        private IWebElement LoginButton;



        public void renderComponents()
        {
            try
            {
                EmailTextbox = driver.FindElement(By.XPath("//*[@placeholder='Email address']"));
                PasswordTextbox = driver.FindElement(By.XPath("//*[@placeholder='Password']"));
                LoginButton = driver.FindElement(By.XPath("//*[text()='Login']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void DoSignIn()
        {

            renderComponents();


            List<Login> credentialsList = JsonReader.ReadTestDataFromJson<Login>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\LoginCredentials.json");

            EmailTextbox.SendKeys(credentialsList[0].Email);
            PasswordTextbox.SendKeys(credentialsList[0].Password);
                LoginButton.Click();
                Thread.Sleep(5000);
            
        }
    }
}
