using AdvancedTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AdvancedTask.Pages.Components.ProfileOverview
{
    public class NotificationComponent:BaseClass
    {
        private IWebElement SeeAllLink;
        private IWebElement LoadMoreLink;
        private IWebElement SeeLessLink;
        private IWebElement SelectAllLink;
        private IWebElement UnselectAllLink;
        private IWebElement MarkAsReadLink;
        private IWebElement PopUpMessage;
        private IWebElement SelectNotification;
        private IWebElement DeleteNotificationLink;
        
        public void renderNotificationComponents()
        {
            try
            {
                SeeAllLink = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLoadMoreCompnents()
        {
            try
            {
                LoadMoreLink = driver.FindElement(By.XPath("//a[contains(text(),'Load More...')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSeeLessComponents()
        {
            try
            {

                SeeLessLink = driver.FindElement(By.XPath("//a[contains(text(),'...Show Less')]"));
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSelectAllComponents()
        {
            try
            {
                SelectAllLink = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderUnselectAllComponents()
        {
            try
            {
                UnselectAllLink = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderMarkAsReadComponents()
        {
            try
            {
                MarkAsReadLink = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderSelectNotificationsComponents()
        {
            try
            {
                SelectNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));
                                                                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void renderDeleteComponents()
        {
            try
            {
                DeleteNotificationLink = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]"));
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

        public bool SelectSeeAll()
        {
            try
            {
                renderNotificationComponents();
                SeeAllLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine( ex);
                return false;
            }
        }
        public bool SelectLoadMore()
        {
            try
            {
                renderLoadMoreCompnents();
                LoadMoreLink.Click();
                return true;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine( ex);
                return false;
            }
        }

        public bool SelectShowLess()
        {
            try
            {
                renderLoadMoreCompnents();
                Thread.Sleep(2000);
                LoadMoreLink.Click();
                Thread.Sleep(2000);
                renderSeeLessComponents();
                Thread.Sleep(3000);
                SeeLessLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool SelectSelectAll()
        {
            try
            {
                renderSelectAllComponents();
                SelectAllLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex);
                return false;
            }
        }
        public bool SelectUnselectAll()
        {
            try
            {
                renderSelectAllComponents();
                SelectAllLink.Click();
                renderUnselectAllComponents();
                WebDriverWait wait = new (driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]")));
                UnselectAllLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool SelectMarkAsRead()
        {
            try
            {
                renderSelectAllComponents();
                SelectAllLink.Click();
                renderMarkAsReadComponents();
                WebDriverWait wait = new (driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]")));
                MarkAsReadLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool SelectDeleteSelectionButton()
        {
            try
            {
                renderSelectNotificationsComponents();
                SelectNotification.Click();
                renderDeleteComponents();
                WebDriverWait wait = new (driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]")));
                DeleteNotificationLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public string GetMessageBoxText()
        {
            try
            {
                renderAddMessage();
                WebDriverWait wait = new (driver, TimeSpan.FromSeconds(10));               
                Thread.Sleep(3000);
                if (PopUpMessage != null)
                {
                    string Message = PopUpMessage.Text;
                    return Message;
                }
                else
                {
                    return "Message element not found";
                }
            }
            catch (NoSuchElementException ex)
            {
                // Handle the case where the element is not found
                Console.WriteLine("Element not found: " + ex.Message);
                return "Message element not found";
            }
        }
    }
}
