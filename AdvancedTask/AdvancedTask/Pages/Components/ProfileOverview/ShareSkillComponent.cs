using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using AventStack.ExtentReports.Model;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class ShareSkillComponent:BaseClass
    {
        private IWebElement TitleBox;
        private IWebElement DescriptionBox;
        private IWebElement CategoryBox;
        private IWebElement SubcategoryBox;
        private IWebElement AddTagsBox;
        private IWebElement HourlyBasisBox;
        private IWebElement ClickOneOffBox;
        private IWebElement PopUpMessage;
        private IWebElement ClickOnsite;
        private IWebElement ClickOnline;
        private IWebElement StartDateBox;
        private IWebElement EndDateBox;
        private IWebElement SelectedDayBox;
        private IWebElement StartTimeBox;
        private IWebElement EndTimeBox;
        private IWebElement ClickCredit;
        private IWebElement EnterCharge;
        private IWebElement ClearTag;
        private IWebElement SaveButton;
        private IWebElement ShareSkillDeleteIcon;
        private IWebElement ClickYes;
        private readonly string Message = "";
        private IWebElement UpdateShareSkillIcon;
        private IWebElement ManageListingTab;
        public void renderTitleComponents()
        {
            try
            {
                TitleBox = driver.FindElement(By.Name("title"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescriptionComponents()
        {
            try
            {
                DescriptionBox = driver.FindElement(By.Name("description"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCategoryComponents()
        {
            try
            {
                CategoryBox = driver.FindElement(By.Name("categoryId"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSubCategoryComponents()
        {
            try
            {
                SubcategoryBox = driver.FindElement(By.Name("subcategoryId"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderTagsComponent()
        {
            try
            {
                AddTagsBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderServiceTypeComponent()
        {
            try
            {
                HourlyBasisBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
                ClickOneOffBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLocationTypeComponent()
        {
            try
            {
                ClickOnsite = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
                ClickOnline = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAvailableDaysComponent()
        {
            try
            {
                StartDateBox = driver.FindElement(By.Name("startDate"));
                EndDateBox = driver.FindElement(By.Name("endDate"));
                SelectedDayBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
                StartTimeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
                EndTimeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSkillTrade()
        {
            try
            {
                ClickCredit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderCredit()
        {
            try
            {
                EnterCharge = driver.FindElement(By.Name("charge"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderClearTag()
        {
            try
            {
                ClearTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/span[2]/a[last()]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderSaveButton()
        {
            try
            {
                SaveButton = driver.FindElement(By.XPath("//input[@type='button'][@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void AddShareSkill(string Title, string Description, string Category, string Subcategory, string Tagone, string Tagtwo,  string EndDate, string StartTime, string EndTime, string Charge)
        {
            renderTitleComponents();
            renderDescriptionComponents();
            renderCategoryComponents();
            renderTagsComponent();
            renderServiceTypeComponent();
            renderLocationTypeComponent();
            renderAvailableDaysComponent();
            TitleBox.SendKeys(Title);
            DescriptionBox.SendKeys(Description);
            CategoryBox.Click();
            CategoryBox.SendKeys(Category);
            CategoryBox.Click();
            renderSubCategoryComponents();
            SubcategoryBox.Click();
            Thread.Sleep(1000);
            SubcategoryBox.SendKeys(Subcategory);
            SubcategoryBox.Click();
            Thread.Sleep(2000);
            AddTagsBox.Click();
            Thread.Sleep(1000);
            AddTagsBox.SendKeys(Tagone);
            AddTagsBox.SendKeys(Keys.Enter);
            AddTagsBox.SendKeys(Tagtwo);
            AddTagsBox.SendKeys(Keys.Enter);
            ClickOneOffBox.Click();
            ClickOnsite.Click();
           // StartDateBox.Click();
            //StartDateBox.SendKeys(StartDate);
            Thread.Sleep(2000);
            EndDateBox.Click();
            EndDateBox.SendKeys(EndDate);
            SelectedDayBox.Click();
            StartTimeBox.Click();
            Thread.Sleep(1000);
            StartTimeBox.SendKeys(StartTime);
            Thread.Sleep(2000);
            EndTimeBox.Click();
            EndTimeBox.SendKeys(EndTime);
            Thread.Sleep(1000);
            renderSkillTrade();
            ClickCredit.Click();
            renderCredit();
            EnterCharge.Click();
            EnterCharge.SendKeys(Charge);
            Thread.Sleep(1000);
            renderSaveButton();
            SaveButton.Click();
            Thread.Sleep(8000);
        }

        public void AddShareSkillWithoutRequirdFeilds(string Title, string Description, string Category, string Subcategory, string Tagone, string Tagtwo, string EndDate, string StartTime, string EndTime, string Charge)
        {


            if (Title != null)
            {
                renderTitleComponents();
                TitleBox.SendKeys(Title);
            }
            if (Description != null)
            {
                renderDescriptionComponents();
                DescriptionBox.Click();
                DescriptionBox.SendKeys(Description);
            }
          
            renderCategoryComponents();
            CategoryBox.Click();
            CategoryBox.SendKeys(Category);
            CategoryBox.Click();
            renderSubCategoryComponents();
            SubcategoryBox.Click();
            Thread.Sleep(1000);
            SubcategoryBox.SendKeys(Subcategory);
            SubcategoryBox.Click();
            Thread.Sleep(2000);
            renderTagsComponent();
            AddTagsBox.Click();
            Thread.Sleep(1000);
            AddTagsBox.SendKeys(Tagone);
            AddTagsBox.SendKeys(Keys.Enter);
            AddTagsBox.SendKeys(Tagtwo);
            AddTagsBox.SendKeys(Keys.Enter);
            renderServiceTypeComponent();
            ClickOneOffBox.Click();
            renderLocationTypeComponent();
            ClickOnsite.Click();
            // StartDateBox.Click();
            //StartDateBox.SendKeys(StartDate);
            Thread.Sleep(2000);
            renderAvailableDaysComponent();
            EndDateBox.Click();
            EndDateBox.SendKeys(EndDate);
            SelectedDayBox.Click();
            StartTimeBox.Click();
            Thread.Sleep(1000);
            StartTimeBox.SendKeys(StartTime);
            Thread.Sleep(2000);
            EndTimeBox.Click();
            EndTimeBox.SendKeys(EndTime);
            Thread.Sleep(1000);
            renderSkillTrade();
            ClickCredit.Click();
            renderCredit();
            EnterCharge.Click();
            EnterCharge.SendKeys(Charge);
            Thread.Sleep(1000);
            renderSaveButton();
            SaveButton.Click();
            Thread.Sleep(8000);
        }

        public void renderUpdateShareSkillIcon()
        {
            try
            {
                //ManageListingTab = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
                UpdateShareSkillIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ClickonUpdateShareSkill()
        {
            renderUpdateShareSkillIcon();
            Thread.Sleep(2000);
            //ManageListingTab.Click();
            Thread.Sleep(4000);
            UpdateShareSkillIcon.Click();
            Thread.Sleep(4000);

        }

        public void UpdateShareSkill(string Title, string Description, string Category, string Subcategory, string Tagone, string Tagtwo,  string EndDate, string StartTime, string EndTime, string Charge)
        {
            renderTitleComponents();
            renderDescriptionComponents();
            renderCategoryComponents();
            renderTagsComponent();
            renderAvailableDaysComponent();
            TitleBox.Clear();
            TitleBox.SendKeys(Title);
            DescriptionBox.Clear();
            DescriptionBox.SendKeys(Description);
            Thread.Sleep(1000);
            CategoryBox.Click();
            Thread.Sleep(1000);
            CategoryBox.SendKeys(Category);
            CategoryBox.Click();
            Thread.Sleep(1000);
            renderSubCategoryComponents();
            SubcategoryBox.Click();
            Thread.Sleep(1000);
            SubcategoryBox.SendKeys(Subcategory);
            SubcategoryBox.Click();
            Thread.Sleep(2000);
            renderClearTag();
            ClearTag.Click();
            Thread.Sleep(1000);
            AddTagsBox.SendKeys(Tagone);
            AddTagsBox.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            AddTagsBox.SendKeys(Tagtwo);
            AddTagsBox.SendKeys(Keys.Enter);
            //StartDateBox.Click();
           // StartDateBox.SendKeys(StartDate);
            Thread.Sleep(2000);
            EndDateBox.Click();
            EndDateBox.SendKeys(EndDate);
            SelectedDayBox.Click();
            StartTimeBox.Click();
            Thread.Sleep(1000);
            StartTimeBox.SendKeys(StartTime);
            Thread.Sleep(2000);
            EndTimeBox.Click();
            EndTimeBox.SendKeys(EndTime);
            Thread.Sleep(1000);
            renderSkillTrade();
            ClickCredit.Click();
            renderCredit();
            EnterCharge.Click();
            EnterCharge.SendKeys(Charge);
            Thread.Sleep(1000);
            renderSaveButton();
            SaveButton.Click();
        }
        public void renderDeleteIcon()
        {
            try
            {
                ShareSkillDeleteIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteConfirmation()
        {
            try
            {

                ClickYes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        
        public void DeleteShareSkill()
        {
            renderDeleteIcon();
            ShareSkillDeleteIcon.Click();
            Thread.Sleep(2000);
            renderDeleteConfirmation();
            ClickYes.Click();
        }
        public void renderMessage()
        {
            try
            {
                PopUpMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public string GetPopUpMessageText()
        {
            renderMessage();
            Thread.Sleep(2000);
            //get the text of the message element
            string Message = PopUpMessage.Text;
            return Message;
        }
    }
}
