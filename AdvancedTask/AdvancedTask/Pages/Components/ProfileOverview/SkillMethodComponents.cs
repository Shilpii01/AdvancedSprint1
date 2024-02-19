using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V119.Debugger;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class SkillMethodComponents:BaseClass
    {
        private IWebElement AddSkillTextBox;
        private IWebElement SelectSkillLevel;
        private IWebElement AddButton;
        private IWebElement PopUpMessage;
        private string message = "";
        private IWebElement UpdateSkillTextBox;
        private IWebElement UpdateSkillLevel;
        private IWebElement UpdateSkillButton;
        public ReadOnlyCollection<IWebElement> SkillRow;
        public IWebElement DeleteIcon;
        public void renderAddComponents()
        {
            try
            {
                AddSkillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
                SelectSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
                AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddMessage()
        {
            try
            {
                PopUpMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void AddSkill(string SkillName, string SkillLevel)
        {
            renderAddComponents();
            AddSkillTextBox.Click();
            //Enter the skills that needs to be added
            AddSkillTextBox.SendKeys(SkillName);
            Thread.Sleep(2000);
            //Choose the skill level
            SelectSkillLevel.Click();
            SelectSkillLevel.SendKeys(SkillLevel);
            //Click onn Add button
            AddButton.Click();
            Thread.Sleep(3000);
        }
        public void renderupdateComponents()
        {
            try
            {
                UpdateSkillTextBox = driver.FindElement(By.Name("name"));
                UpdateSkillLevel = driver.FindElement(By.Name("level"));
                UpdateSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AddNewSkillRecordWithoutRequirdFeilds(string SkillName, string SkillLevel)
        {


            if (SkillName != null)
            {
                renderAddComponents();
                AddSkillTextBox.SendKeys(SkillName);
            }
            if (SkillLevel != null)
            {
                renderAddComponents();
                SelectSkillLevel.Click();
                SelectSkillLevel.SendKeys(SkillLevel);
            }

            AddButton.Click();
            Thread.Sleep(3000);
        }
        public void UpdateSkill(string SkillName, string SkillLevel)
        {
            renderupdateComponents();
            //UpdateSkillTextBox.SendKeys(Keys.Control + "A");
            UpdateSkillTextBox.Click();
            UpdateSkillTextBox.Clear();
            UpdateSkillTextBox.SendKeys(SkillName);
            Thread.Sleep(2000);
            //Choose the level from the drop down
            UpdateSkillLevel.Click();
            UpdateSkillLevel.SendKeys(SkillLevel);
            //Click on update button
            UpdateSkillButton.Click();
            Thread.Sleep(2000);
        }

        public void renderDeleteSkill()
        {
            try
            {
                DeleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void DeleteSkill(string SkillName, string SkillLevel)
        {
            try
            {
                var deleteIcon = driver.FindElement(By.XPath($"//tbody[tr[td[text()='{SkillName}'] and td[text()='{SkillLevel}']]]//i[@class='remove icon']"));
                // Find and click the delete icon in the row
                deleteIcon.Click();
                Thread.Sleep(2000);
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("Delete Skill element not found");
            }
        }
        public string GetPopUpMessageText()
        {
            renderAddMessage();
            //get the text of the message element
            string Message = PopUpMessage.Text;
            return Message;
        }

        public void ClearExistingSkills()
        {
            // SkillRow = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));          

            //Thread.Sleep(2000);
            //int totalrows = SkillRow.Count;
            //Console.WriteLine(totalrows);
            //    for (int i = 0; i < totalrows; i = i + 1)
            //    {
            //        renderDeleteSkill();
            //        DeleteIcon.Click();
            //        Thread.Sleep(2000);
            //    }

            {

                try
                {

                    IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                    foreach (var button in deleteButtons)
                    {
                        button.Click();
                        Thread.Sleep(2000);
                    }

                }
                catch (NoSuchElementException)
                { Console.WriteLine("no items to delete"); }
            }
        }


    }
}
