using AdvancedTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class LanguageComponent:BaseClass
    {

        public IWebElement AddNewButton;
        private IWebElement EditLanguageIcon;
        public void renderComponents()
        {
            try
            {
                AddNewButton = driver.FindElement(By.XPath("//div[@data-tab='first']//div[@class ='ui teal button ']"));
                EditLanguageIcon = driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody/tr/td[3]/span[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickAddLanguage()
        {
            renderComponents();
            AddNewButton.Click();
        }
        public void ClickUpdateLanguage()
        {
            renderComponents();
            Thread.Sleep(2000);
            EditLanguageIcon.Click();
        }
    }
}
