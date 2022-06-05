using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests : AuthBaseTest
    {
        [TestCase(TestName = "Добавление группы a a")]
        public void GroupCreationTest()
        {
            List<GroupData> oldGroup = applicationManager.Groups.GetGroupList();
            GroupData group = new GroupData("a");
            group.Header = "a";
            group.Footer = "a";
            applicationManager.Groups.Create(group);
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroup.Count + 1, newGroup.Count);
        }

        [TestCase(TestName = "Добавление группы")]
        public void EmptyGroupCreationTest()
        {
            List<GroupData> oldGroup = applicationManager.Groups.GetGroupList();
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            applicationManager.Groups.Create(group);
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroup.Count + 1, newGroup.Count);
        }

        [TestCase(TestName = "Некорректное имя группы")]
        public void BadNameGroupCreationTest()
        {
            List<GroupData> oldGroup = applicationManager.Groups.GetGroupList();
            GroupData group = new GroupData("a'a");
            group.Header = "";
            group.Footer = "";
            applicationManager.Groups.Create(group);
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroup.Count + 1, newGroup.Count);
        }
    }
}