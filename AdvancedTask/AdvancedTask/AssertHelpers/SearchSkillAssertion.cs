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


        public void SearchSkillAssert()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkill.json");


            IWebElement SearchedSkill = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/a[2]/p[1]"));

           string  Message = SearchedSkill.Text;

            Assert.That(Message == SearchSkillData[0].Skill, "Searched skills are not matched");
          
        }

        public void SearchInvalidSkillAssert()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByInvalidData.json");

            
            bool link = driver.FindElement(By.XPath("//h3[contains(text(),'No results found, please select a new category!')]")).Enabled;
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
           
            IWebElement  Username = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/a[1]"));
            string Username1 = Username.Text;
            Thread.Sleep(2000);

            Assert.That(Username1 == SearchSkillData[0].Username, "Username is not matched");
         
        }

        public void SearchCategoryAssert()
        {

            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByCategoryData.json");
           
            string CategorySearched = SearchSkillData[0].Category;
            bool categoryXpath = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[2]/b")).Enabled;
            
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
            bool OnlineOption = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]")).Enabled;

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
