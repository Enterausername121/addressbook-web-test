using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupRemovalTests : AuthBaseTest

    {
        [TestCase(TestName = "Удаление группы")]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroup = applicationManager.Groups.GetGroupList();

            applicationManager.Groups.Remove();
            List<GroupData> newGroup = applicationManager.Groups.GetGroupList();
            Assert.AreEqual(oldGroup.Count - 1, applicationManager.Groups.GetGroupCount());
            GroupData toBeRemoved = oldGroup[0];
            oldGroup.RemoveAt(0);
            Assert.AreEqual(oldGroup, newGroup);
            foreach (GroupData group in newGroup)
            {
                Assert.AreNotEqual(group.Id, toBeRemoved.Id);
            }
        }
    }
}
