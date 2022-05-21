using System;
using NUnit.Framework;
namespace addressbook_web_test
{
    [TestFixture]
    public class LoginTest: BaseTest
    {
        [Test]
        public void LoginWithInvalidCredentials()
        {
            // prepare
            applicationManager.Auth.Logout();
            // action
            AccountData account = new AccountData("admin", "123456");
            applicationManager.Auth.Login(account);
            //verification
            Assert.IsFalse(applicationManager.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithValidCredentials()
        {
            // prepare
            applicationManager.Auth.Logout();
            // action
            AccountData account = new AccountData("admin", "secret");
            applicationManager.Auth.Login(account);
            //verification
            Assert.IsTrue(applicationManager.Auth.IsLoggedIn(account));
        }

        
    }
}
