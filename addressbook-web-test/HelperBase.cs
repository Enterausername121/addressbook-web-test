using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace addressbook_web_test
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }    
}