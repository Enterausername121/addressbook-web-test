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

        public LoginHelper Login(AccountData account)
        {
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
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
