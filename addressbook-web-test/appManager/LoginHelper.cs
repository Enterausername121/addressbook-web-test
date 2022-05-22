using System;
using OpenQA.Selenium;


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

        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }

                Logout();
            }
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
           && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text == "(" + account.Username + ")";
     
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout")); 
        }

        public LoginHelper Logout()
        {
            if (IsLoggedIn() == true)
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
            
            return this;
        }

    }
}
