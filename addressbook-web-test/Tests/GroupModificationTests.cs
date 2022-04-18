using NUnit.Framework;

namespace addressbook_web_test.Tests
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

    }
}
