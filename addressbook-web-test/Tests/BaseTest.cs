using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace addressbook_web_test
{
    public class BaseTest
    {
        
        protected ApplicationManager applicationManager;
        

        [SetUp]
        public void SetupTest()
        {
            applicationManager = new ApplicationManager();
            applicationManager.Auth.OpenHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            applicationManager.Stop();
        }                                         
    }
}

    
