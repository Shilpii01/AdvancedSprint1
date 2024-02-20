using AdvancedTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class ProfileTabComponents: BaseClass
    {
        private IWebElement LanguagesTab;
        private IWebElement SkillTab;
        private IWebElement NotificationTab;
        private IWebElement SearchSkillTextbox;
        private IWebElement ShareSkillButton;
        private IWebElement AvailabilityEditIcon;
        private IWebElement HoursEditIcon;
        private IWebElement EarnTargetEditIcon;
        private IWebElement Dashboard;
        private IWebElement SearchSkillIcon;


        public void renderComponents()
        {
            try
            {
                LanguagesTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
               
                ShareSkillButton = driver.FindElement(By.XPath("//*[contains(text(), 'Share Skill')]"));                              
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       
        public void renderUserDetailsComponents()
        {
            try
            {
                
                AvailabilityEditIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
                HoursEditIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
                EarnTargetEditIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       


        public void renderNotificationComponents()
        {
            try
            {
                
                NotificationTab = driver.FindElement(By.XPath("//*[contains(text(), 'Notification')]"));

                Dashboard = driver.FindElement(By.XPath("//a[contains(text(),'Dashboard')]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSearchSkillIconComponents()
        {
            try
            {
                SearchSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder=\"Search skills\"]"));
                SearchSkillIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/div[1]/div[1]/i[1]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void ClickLangaugesTab()
        {
            renderComponents();
            Thread.Sleep(1000);
            LanguagesTab.Click();
            Thread.Sleep(1000);


        }

        public void renderSkillTabComponents()
        {
            try
            {
                Thread.Sleep(2000);
                SkillTab = driver.FindElement(By.XPath("//a[@class=\"item\"][@data-tab =\"second\"]"));
                Thread.Sleep(2000);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ClickSkillsTab()
        {
            renderSkillTabComponents();
            Thread.Sleep(2000);
            SkillTab.Click();
           
            Thread.Sleep(1000);


        }

        public void ClickAvailabilityIcon()
        {
            renderUserDetailsComponents();
            AvailabilityEditIcon.Click();

        }
        public void ClickHoursIcon()
        {
            renderUserDetailsComponents();
            HoursEditIcon.Click();
        }
        public void ClickEarnTargetIcon()
        {
            renderUserDetailsComponents();
            EarnTargetEditIcon.Click();
        }
        public void ClickShareSkillButton()
        {
            renderComponents();
            ShareSkillButton.Click();
            Thread.Sleep(1000);
        }

       

        public void ClickSearchTextbox()
        {
            renderComponents();
            SearchSkillTextbox.Click();
        }

        public void ClickSearchSkillIcon()
        {


            renderSearchSkillIconComponents();
            Thread.Sleep(1000);
            SearchSkillIcon.Click();
            Thread.Sleep(1000);

        }
        public void ClickNotificationTab()
        {
            renderNotificationComponents();
            Thread.Sleep(2000);
            NotificationTab.Click();
        }

        public void ClickDashboard()
        {
            renderNotificationComponents();
            Thread.Sleep(2000);
            Dashboard.Click();

        }


    }
}
