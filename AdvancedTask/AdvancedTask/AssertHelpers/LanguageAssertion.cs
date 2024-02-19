using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.AssertHelpers
{
    public class LanguageAssertion:BaseClass
    {

        LanguageMethodComponents LanguageMethodComponentsObj;

        public LanguageAssertion()
        {
            LanguageMethodComponentsObj = new LanguageMethodComponents();

        }

        public void AssertAddedLanguage()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddValidLanguage.json");

            //LanguageMethodComponentsObj.AddNewLanguage(LanguageData[0].LanguageName, LanguageData[0].LanguageLevel);
            IWebElement LanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            string NewLanguage = LanguageRecord.Text;
            Assert.That(LanguageData[0].LanguageName == NewLanguage, "Language is not added successfully");

        }

        public void AssertInvalidLanguage()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddInvalidLang.json");


            string NewLanguage = LanguageMethodComponentsObj.GetPopUpMessageText();
            Assert.That(NewLanguage == "Please enter language and level", "Invalid Language Added");

        }
        public void AssertDestructiveLanguage()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddDestructiveLang.json");
            Thread.Sleep(2000);
            IWebElement LanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Thread.Sleep(2000);
            string NewLanguage = LanguageRecord.Text;
            Assert.That(LanguageData[0].LanguageName == NewLanguage, "Language is not added successfully");
          
        }


        public void AssertUpdatedLanguage()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\UpdatedLanguage.json");

            //LanguageMethodComponentsObj.UpdateLanguage(LanguageData[0].LanguageName, LanguageData[0].LanguageLevel);
            string NewLanguage = LanguageMethodComponentsObj.GetPopUpMessageText();
            Assert.That(NewLanguage == LanguageData[0].LanguageName + " has been updated to your languages", "Language has not been updated");

        }
        public string AssertDeletedLanguage()
        {

           string NewLanguage = LanguageMethodComponentsObj.GetPopUpMessageText();
           return NewLanguage;

        }
    }
}
