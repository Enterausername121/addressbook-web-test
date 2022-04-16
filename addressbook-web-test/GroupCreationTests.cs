using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests:BaseTest
    {        
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("a");
            group.Header = "a";
            group.Footer = "a";
            FillGroupForm(group);
            SubmitGroupCreation();
            GoToGroupsPage();
            Logout();
        }            
    }
}