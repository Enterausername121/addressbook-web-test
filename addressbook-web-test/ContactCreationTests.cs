using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_test
{
    [TestFixture]
    public class ContactCreationTests:BaseTest
    {
        
        [Test]
        public void ContactCreationTest()
        {
            loginHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToNewContactPage();
            contactHelper.FillContactForm(new ContactData("a", "a"));
            navigationHelper.GoToHomePage();
            loginHelper.Logout();
        }
    }
        
}
