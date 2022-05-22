using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        private static ThreadLocal<ApplicationManager> applicationManager = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(this, baseURL);
            navigationHelper = new NavigationHelper(this);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }


        public IWebDriver? Driver
        { 
            get
            { 
                return driver; 
            }
        }
        public LoginHelper Auth
        {
            get { return loginHelper; }
        }
        public NavigationHelper Navigator
        {
            get { return navigationHelper; } 
        }

        public GroupHelper Groups
        {
            get { return groupHelper; }
        }

        public ContactHelper Contacts
        {
            get { return contactHelper; }
        }

        public static ApplicationManager GetInstance()
        {
            if (! applicationManager.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Auth.OpenHomePage();
                applicationManager.Value = newInstance;
                
            }

            return applicationManager.Value;
        }
    }
}
