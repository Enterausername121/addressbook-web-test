using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupRemovalTests : BaseTest

    {      
        [Test]
        public void GroupRemovalTest()
        {
            loginHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.SelectGroup();
            groupHelper.RemoveGroup(1);
            navigationHelper.GoToGroupsPage();
            loginHelper.Logout();
        }                      
    }
}
