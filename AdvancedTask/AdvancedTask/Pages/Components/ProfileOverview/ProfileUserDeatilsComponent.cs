using AdvancedTask.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTask.Test_Model;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class ProfileUserDeatilsComponent:BaseClass
    {
      
        private IWebElement SaveButton;
        private IWebElement AvailabilityDropdown;
        private IWebElement HoursDropdown;
        private IWebElement EarnTargetDropdown;
        private IWebElement PopUpMessage;
        private string Message = "";
       
        public void renderAddMessage()
        {
            try
            {
                PopUpMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderAvailability()
        {
            try
            {
                AvailabilityDropdown = driver.FindElement(By.XPath("//select [@class=\"ui right labeled dropdown\"][@name = \"availabiltyType\"]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void renderHours()
        {
            try
            {
                HoursDropdown = driver.FindElement(By.Name("availabiltyHour"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderTarget()
        {
            try
            {
               EarnTargetDropdown = driver.FindElement(By.Name("availabiltyTarget"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        
        public void AddAvailability(string Availability)
        {
            renderAvailability();
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement AvailabilityDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select")));
            AvailabilityDropdown.Click();
            AvailabilityDropdown.SendKeys(Availability);

            AvailabilityDropdown.Click();
            Thread.Sleep(2000);
        }
        public void AddHours(string  Hours)
        {
            renderHours();
            Thread.Sleep(2000);
            HoursDropdown.Click();
            
            HoursDropdown.SendKeys(Hours);
            HoursDropdown.Click();
            Thread.Sleep(2000);
        }
        public void AddEarnTarget(string EarnTarget)
        {
            renderTarget();
            Thread.Sleep(1000);
            EarnTargetDropdown.Click();
          
            EarnTargetDropdown.SendKeys(EarnTarget);
            EarnTargetDropdown.Click();
            Thread.Sleep(2000);
        }
        public string GetMessageBoxText()
        {
            renderAddMessage();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement PopUpMessage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ns-box-inner']")));
            //get the text of the message element
            string Message = PopUpMessage.Text;
            return Message;
        }

    }
}
