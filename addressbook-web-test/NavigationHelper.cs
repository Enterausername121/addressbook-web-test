using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(IWebDriver driver) : base(driver)
        {
            
        }
       
        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToNewContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
