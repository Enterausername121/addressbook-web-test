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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToNewContactPage();
            FillContactForm(new ContactData("a", "a"));
            OpenHomeLink();
            Logout();
        }
    }
}
