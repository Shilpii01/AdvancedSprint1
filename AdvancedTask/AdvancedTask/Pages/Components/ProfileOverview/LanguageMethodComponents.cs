using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class LanguageMethodComponents:BaseClass
    {

        LanguageComponent languageComponent = new LanguageComponent();

        private IWebElement AddLanguageTextbox;
        private IWebElement SelectLanguageLevel;
        private IWebElement AddButton;
        private IWebElement UpdateLangaugeTextbox;
        private IWebElement SelectUpdateLevel;
        public ReadOnlyCollection<IWebElement> Row;
        private IWebElement UpdateButton;
        public IWebElement PopUpMessage;
        private IWebElement DeleteIcon;
         public string Message = "";
        IWebElement LanguageRecord;

        public void renderAddComponents()
        {
            try
            {
                AddLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
                SelectLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
                AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
      
        public void renderUpdateLanguage()
        {
            try
            {
                UpdateLangaugeTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
                SelectUpdateLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
                UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void AddNewLanguage(string LanguageName, string LanguageLevel)
        {
            renderAddComponents();
            AddLanguageTextbox.SendKeys(LanguageName);
            //Choose the language level
            SelectLanguageLevel.Click();
            SelectLanguageLevel.SendKeys(LanguageLevel);
            Thread.Sleep(3000);
            //Click on Add button
            AddButton.Click();
            Thread.Sleep(5000);
        }

        public void renderLanguageRecord()
        {

            IWebElement LanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        }
        public void AddNewLanguageRecordWithoutRequirdFeilds(string LanguageName, string LanguageLevel)
        {

          
            if (LanguageName != null)
            {
                renderAddComponents();
                AddLanguageTextbox.SendKeys(LanguageName);
            }
            if (LanguageLevel != null)
            {
                renderAddComponents();
                SelectLanguageLevel.Click();
                SelectLanguageLevel.SendKeys(LanguageLevel);
            }

            AddButton.Click();
            Thread.Sleep(3000);
        }

        public void UpdateLanguage(string UpdatedLanguageName, string UpdatedLanguageLevel)
        {
            renderUpdateLanguage();
            //Edit the language
            UpdateLangaugeTextbox.Clear();
            UpdateLangaugeTextbox.SendKeys(UpdatedLanguageName);
            Thread.Sleep(1000);
            //Choose the level from the drop down
            SelectUpdateLevel.Click();
            Thread.Sleep(1000);
            SelectUpdateLevel.SendKeys(UpdatedLanguageLevel);
            //Click on Update button
            UpdateButton.Click();
            Thread.Sleep(2000);
        }

        public void renderDeleteLanguage()
        {
            try
            {
                DeleteIcon = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteLanguage()
        {
            Row = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody"));

            int rowCount = Row.Count;

            for (int i = 0; i < rowCount; i = i + 1)
            {
                try
                {
                    renderDeleteLanguage();
                    DeleteIcon.Click();
                    Thread.Sleep(2000);
                }
                catch (StaleElementReferenceException) { }
            }
            


        }

        public string GetLanguageRecordText()
        {
            renderLanguageRecord();
            string LanguageRecordText = LanguageRecord.Text;
            return LanguageRecordText;

        }
        public string GetPopUpMessageText()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PopUpMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(3000);
            string Message = PopUpMessage.Text;
            return Message;
        }

        public void ClearExistingLanguages()
        {
            Row = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
            Thread.Sleep(2000);
            int totalrows = Row.Count;
            Console.WriteLine(totalrows);
            for (int i = 0; i < totalrows; i = i + 1)
            {
                renderDeleteLanguage();
                DeleteIcon.Click();
                Thread.Sleep(2000);
            }

        }




    }
}
