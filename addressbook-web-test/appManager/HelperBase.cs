using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace addressbook_web_test
{
    public class HelperBase
    {
        protected ApplicationManager applicationManager;
        public IWebDriver driver;
        private string baseURL;

        public HelperBase(ApplicationManager applicationManager)
        {
            this.applicationManager = applicationManager;
            driver = applicationManager.Driver; 
        }

        public HelperBase(IWebDriver driver, string baseURL) 
        {
            this.baseURL = baseURL;
        }
    }    
}