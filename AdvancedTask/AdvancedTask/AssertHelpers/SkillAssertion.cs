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
   public class SkillAssertion:BaseClass
    {
        SkillMethodComponents SkillMethodComponentsObj;
        public SkillAssertion()
        {
            SkillMethodComponentsObj = new SkillMethodComponents();
        }
        public void AssertAddedSkill()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddSkill.json");

            
            IWebElement SkillRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            string NewSkill = SkillRecord.Text;
            Assert.That(SkillData[0].SkillName == NewSkill, "Skill is not added successfully");

        }

        public void AssertInvalidSkill()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddInvalidSkill.json");


            string NewLanguage = SkillMethodComponentsObj.GetPopUpMessageText();
            Assert.That(NewLanguage == "Please enter skill and experience level", "Invalid Language Added");

        }
        public void AssertDestructiveSkill()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddDestructiveSkill.json");
            Thread.Sleep(2000);
            IWebElement SkillRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Thread.Sleep(2000);
            string NewSkill = SkillRecord.Text;
            Assert.That(SkillData[0].SkillName == NewSkill, "Skill is not added successfully");

        }


        public void AssertUpdatedSkill()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\UpdatedSkill.json");

            //LanguageMethodComponentsObj.UpdateLanguage(LanguageData[0].LanguageName, LanguageData[0].LanguageLevel);
            string NewSkill = SkillMethodComponentsObj.GetPopUpMessageText();
            Assert.That(NewSkill == SkillData[0].SkillName + " has been updated to your skills", "Language has not been updated");

        }
        public string AssertDeletedSkill()
        {

            string NewSkill = SkillMethodComponentsObj.GetPopUpMessageText();
            return NewSkill;

        }

    }
}
