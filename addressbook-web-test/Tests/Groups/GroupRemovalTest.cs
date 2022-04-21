﻿using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupRemovalTests : BaseTest

    {      
        [Test]
        public void GroupRemovalTest()
        {
            applicationManager.Groups.Remove();
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Auth.Logout();
        }                      
    }
}
