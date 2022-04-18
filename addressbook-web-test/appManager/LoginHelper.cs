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
    public class LoginHelper : HelperBase
    {
        public string baseURL;
        public LoginHelper(ApplicationManager applicationManager, string baseURL) : base(applicationManager)
        {
            this.baseURL = baseURL;
        }

        public LoginHelper OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            return this;
        }

        public LoginHelper Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Id("LoginForm")).Click();
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            return this;
        }
        
        public LoginHelper Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }
    }
}
