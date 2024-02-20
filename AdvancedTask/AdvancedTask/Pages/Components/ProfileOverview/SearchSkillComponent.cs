using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class SearchSkillComponent:BaseClass
    {
        private IWebElement searchSkillsTextbox;
        private IWebElement clickSearch;
        private IWebElement AdduserName;
        private IWebElement Clickusername;
        private IWebElement SearchedSkill;
        private IWebElement InvalidSearchSkilllink;
        private IWebElement Username;
        private IWebElement categoryXpath;
        private IWebElement OnlineOption;
        public void renderSearchComponents()
        {
            try
            {
                searchSkillsTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSearchedSkillName()
        {
            IWebElement SearchedSkill = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/a[2]/p[1]"));

        }
        public void renderClicksearchComponents()
        {
            try
            {

                clickSearch = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAdduser()
        {
            try
            {
                AdduserName = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderclickuser()
        {
            try
            {
                Clickusername = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void SkillToBeSearched(string Skill)
        {
            renderSearchComponents();
            searchSkillsTextbox.Click();
            searchSkillsTextbox.SendKeys(Skill);
            Thread.Sleep(2000);
            renderClicksearchComponents();
            clickSearch.Click();
        }


        public void SearchUser(string Username)
        {
            renderAdduser();
            AdduserName.Click();
            AdduserName.SendKeys(Username);
            Thread.Sleep(2000);
            renderclickuser();
            Clickusername.Click();
        }
        public void SearchByCategory(string Category, string Subcategory)
        {
           
            IWebElement categoryElement = driver.FindElement(By.LinkText(Category));
            categoryElement.Click();

            Thread.Sleep(2000);
            
            IWebElement SubcategoryElement = driver.FindElement(By.LinkText(Subcategory));
            SubcategoryElement.Click();

        }

        public void SearchByFilter(string FilterOption)
        {
            renderClicksearchComponents();

            string buttonText = FilterOption;          

            Thread.Sleep(2000);

            IWebElement ButtonElement = driver.FindElement(By.XPath("//button[contains(text(),'"+buttonText+"')]"));
            ButtonElement.Click();
        

        }

        public String GetSearchedSkillNameText()
        {
            renderSearchedSkillName();
            string SearchSkillName = SearchedSkill.Text;
            return SearchSkillName;

        }

        public void renderInvalidSearchSkill()
        {
             InvalidSearchSkilllink = driver.FindElement(By.XPath("//h3[contains(text(),'No results found, please select a new category!')]"));
        }

        public bool GetInvalidSearchedSkill()
        {
            renderInvalidSearchSkill();
           bool link = InvalidSearchSkilllink.Enabled;
            return true;
        }

        public void renderUsernameText()
        {
             Username = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/a[1]"));
        }

        public string GetUsernameText()
        {
            renderUsernameText();
            string SkillUsername = Username.Text;
            return SkillUsername;
        }

        public void rendercategoryXpath()
        {
             categoryXpath = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[2]/b"));

        }

        public bool GetCategoryXpath()
        {
            rendercategoryXpath();
            bool category= categoryXpath.Enabled;
            return true;
        }

        public void renderfilteroptions()
        {
             OnlineOption = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]"));
        }

        public bool GetFilterOptions()
        {
            renderfilteroptions();
            bool link = OnlineOption.Enabled;
            return true;

        }

    }

}
