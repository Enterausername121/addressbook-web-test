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
            List<GroupData> oldGroups = applicationManager.Groups.GetGroupList();
            GroupData group = new GroupData("a");
            group.Header = "a";
            group.Footer = "a";
            applicationManager.Groups.Create(group);
            
            
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, applicationManager.Groups.GetGroupCount());
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroup.Sort();
            Assert.AreEqual(oldGroups, newGroup);
            
        }

        [TestCase(TestName = "Добавление группы")]
        public void EmptyGroupCreationTest()
        {
            List<GroupData> oldGroups = applicationManager.Groups.GetGroupList();
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            applicationManager.Groups.Create(group);
            
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, applicationManager.Groups.GetGroupCount());
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroup.Sort();
            Assert.AreEqual(oldGroups, newGroup);
        }

        [TestCase(TestName = "Некорректное имя группы")]
        public void BadNameGroupCreationTest()
        {
            List<GroupData> oldGroups = applicationManager.Groups.GetGroupList();
            GroupData group = new GroupData("a'a");
            group.Header = "";
            group.Footer = "";
            applicationManager.Groups.Create(group);
            
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count, applicationManager.Groups.GetGroupCount());
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroup.Sort();
            Assert.AreEqual(oldGroups, newGroup);
            
        }
    }
}