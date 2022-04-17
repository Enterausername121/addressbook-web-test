using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests:BaseTest
    {        
        [Test]
        public void GroupCreationTest()
        {
            loginHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            GroupData group = new GroupData("a");
            group.Header = "a";
            group.Footer = "a";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            navigationHelper.GoToGroupsPage();
            loginHelper.Logout();
        }            
    }
}