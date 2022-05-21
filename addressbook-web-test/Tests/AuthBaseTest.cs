using System;
using NUnit.Framework;

namespace addressbook_web_test
{
    public class AuthBaseTest : BaseTest
    {
        [SetUp]
        public void SetupLogin()
        { 
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
