using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests : BaseTest
    {        
        [Test]
        public void GroupCreationTest()
        {

            GroupData group = new GroupData("a");
            group.Header = "a";
            group.Footer = "a";
            applicationManager.Groups.Create(group);
            applicationManager.Navigator.GoToGroupsPage(); 
            applicationManager.Auth.Logout();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {

            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            applicationManager.Groups.Create(group);
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Auth.Logout();
        }
    }
}