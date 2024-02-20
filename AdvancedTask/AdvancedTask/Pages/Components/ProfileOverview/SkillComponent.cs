using AdvancedTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
   public class SkillComponent:BaseClass
    {
        private IWebElement AddNewSkillButton;
        private IWebElement EditSkillIcon;

        public void renderComponents()
        {
            try
            {
                AddNewSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
                EditSkillIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickAddSkill()
        {
            renderComponents();
            AddNewSkillButton.Click();
        }
        public void ClickUpdateSkill()

        {
            renderComponents();
            EditSkillIcon.Click();
        }

    }
}
