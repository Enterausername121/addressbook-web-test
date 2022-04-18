using NUnit.Framework;



namespace addressbook_web_test
{
    [TestFixture]
    public class ContactCreationTests : BaseTest
    {
        
        [Test]
        public void ContactCreationTest()
        {            
            applicationManager.Navigator.GoToNewContactPage();
            applicationManager.Contacts.FillContactForm(new ContactData("a", "a"));
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Logout();
        }
    }
        
}
