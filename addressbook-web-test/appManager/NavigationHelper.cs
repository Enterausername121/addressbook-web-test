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
        private string baseURL;
        public NavigationHelper(ApplicationManager applicationManager) : base(applicationManager)
        {
            
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "index.php"
                && IsElementPresent(By.XPath("/html/body/div/div[4]/label/strong")))
            {
                return;
            }
            driver.FindElement(By.XPath("//*[@id='logo']")).Click();
        }


        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "group.php"
                && IsElementPresent(By.Name("group page")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        
    }
}
