using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupModificationTests : AuthBaseTest
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("aer");
            newData.Header = "aer";
            newData.Footer = "aer";
            List<GroupData> oldGroups = applicationManager.Groups.GetGroupList();
            applicationManager.Groups.Modify(0, newData);
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroup.Sort();
            Assert.AreEqual(oldGroups, newGroup);

        }

        [Test]
        public void GroupModificationTestNULL()
        {
            GroupData newData = new GroupData("aer");
            newData.Header = "null";
            newData.Footer = "null";
            List<GroupData> oldGroups = applicationManager.Groups.GetGroupList();
            applicationManager.Groups.Modify(0, newData);
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroup.Sort();
            Assert.AreEqual(oldGroups, newGroup);
        }
    }
}
