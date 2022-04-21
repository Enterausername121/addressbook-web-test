using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class ContactModifycationTests : BaseTest
    {
        [Test]
        public void ContactModificationTest() 
        {
            applicationManager.Contacts.ContactModification(new ContactData("rae","rae"));
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Logout();

        }
    }
}
