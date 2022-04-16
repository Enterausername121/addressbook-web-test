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
            OpenHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            SelectGroup();
            RemoveGroup(1);
            GoToGroupsPage();
            Logout();
        }                      
    }
}
