using NUnit.Framework;


namespace addressbook_web_test
{
    [TestFixture]
    public class ContactsRemovalTests : BaseTest
    {
        [Test]
        public void ContactsRemovalTest()
        {
            applicationManager.Contacts.Delete();
            applicationManager.Auth.Logout();
        }
    }
}
