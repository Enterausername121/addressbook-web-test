using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupModificationTests : BaseTest
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("aer");
            newData.Header = "aer";
            newData.Footer = "aer";
            applicationManager.Groups.Modify(1, newData);
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Auth.Logout();
        }

        [Test]
        public void GroupModificationTestNULL()
        {
            GroupData newData = new GroupData("aer");
            newData.Header = null;
            newData.Footer = null;
            applicationManager.Groups.Modify(1, newData);
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Auth.Logout();
        }

    }
}
