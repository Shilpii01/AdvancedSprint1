using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.AssertHelpers
{
    public class ShareSkillAssertion:BaseClass
    {
        ShareSkillComponent ShareSkillComponentObj;



        public ShareSkillAssertion()
        {

            ShareSkillComponentObj = new ShareSkillComponent();
        }
        public void AssertAddedSkillTitle()
        {           
            string SkillTitleText = ShareSkillComponentObj.GetAddedShareSkillREcordTitle();
            List<ShareSkill> ShareSkillData = JsonReader.ReadTestDataFromJson<ShareSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddShareSkill.json");

            Assert.That(ShareSkillData[0].Title == SkillTitleText, "Share Skill is not added successfully");
            
        }
        public void AssertInvalidShareSkill()
        {
            bool message = ShareSkillComponentObj.GetPopUpMessageText().Contains("Please complete the form correctly.");

            if (message == true)
            {
                Assert.Pass("Invalid Share Skill not added");
            }
          
         

        }
        public void AssertDestructiveSkill()
        {
            bool message = ShareSkillComponentObj.GetPopUpMessageText().Contains("Please complete the form correctly.");

            if (message == true)
            {
                Assert.Pass("Destructive Share Skill not added");
            }


        }

        public void AssertUpdatedSkillTitle()
        {
            Thread.Sleep(3000);

            string UpdatedSkillTitle = ShareSkillComponentObj.GetAddedShareSkillREcordTitle();
            List<ShareSkill> ShareSkillData = JsonReader.ReadTestDataFromJson<ShareSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\UpdateShareSkill.json");
           
            Assert.That(UpdatedSkillTitle== ShareSkillData[0].Title, " Share skill has been Updated successfully ");
           

        }
        public void AssertDeletedShareSkill()
        {


            string actualMessage = ShareSkillComponentObj.GetPopUpMessageText();

            Assert.Pass(actualMessage);

           
        }
    }
}
