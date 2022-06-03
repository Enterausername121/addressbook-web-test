using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;


namespace addressbook_web_test
{
    public class HelperBase
    {
        protected ApplicationManager applicationManager;
        public IWebDriver driver;
        public string baseURL;

        public HelperBase(ApplicationManager applicationManager)
        {
            this.applicationManager = applicationManager;
            driver = applicationManager.Driver; 
        }

        //public HelperBase(IWebDriver driver, string baseURL) 
        //{
            //this.baseURL = baseURL;
        //}

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.FindElement(locator).Clear();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.FindElement(locator).SendKeys(text);
            }
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }

            catch (NoSuchElementException)
            {
                return false;
            }

        }

    }    
}