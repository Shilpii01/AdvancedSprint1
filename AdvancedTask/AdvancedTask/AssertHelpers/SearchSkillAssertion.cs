using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.FedCm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.AssertHelpers
{
    public class SearchSkillAssertion:BaseClass
    {
        SearchSkillComponent SearchSkillComponentObj;

        public SearchSkillAssertion()
        {
            SearchSkillComponentObj = new SearchSkillComponent();
        }

        public void SearchSkillAssert()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkill.json");

           string  Message = SearchSkillComponentObj.GetSearchedSkillNameText();

            Assert.That(Message == SearchSkillData[0].Skill, "Searched skills are not matched");
          
        }

        public void SearchInvalidSkillAssert()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByInvalidData.json");


            bool link = SearchSkillComponentObj.GetInvalidSearchedSkill();
            if (link==true) 
            {
                Assert.Pass("No results Display");
            }
            else
            {
                Assert.Fail("Skill is not invalid");
            }

            

        }
        public void SearchUserNameAssert()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByUsername.json");


            string Username1 = SearchSkillComponentObj.GetUsernameText();
            Thread.Sleep(2000);

            Assert.That(Username1 == SearchSkillData[0].Username, "Username is not matched");
         
        }

        public void SearchCategoryAssert()
        {

            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByCategoryData.json");
           
            string CategorySearched = SearchSkillData[0].Category;
            bool categoryXpath = SearchSkillComponentObj.GetCategoryXpath();
            
            if ((CategorySearched== "Graphics & Design") && (categoryXpath==true))
            {
                Assert.Pass("Searched skill categories are same");
            }
            else
            {
                Assert.Fail("The Category skill you are searching has not been found");
            }

        }
        public void SearchFilterAssert()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByFilterData.json");
            string buttonText = SearchSkillData[0].FilterOption;
            bool OnlineOption = SearchSkillComponentObj.GetFilterOptions();

            if ((buttonText == "Onsite") && (OnlineOption == true)) 
            {
                Assert.Pass("Skills can be searched using filter option");

            }
            else
            {
                Assert.Fail("Skills Can't be searched through filter option");
            }
          
        }
    }
}
