using NUnit.Framework;



namespace addressbook_web_test
{
    [TestFixture]
    public class ContactCreationTests : BaseTest
    {
        
        [TestCase(TestName = "Создание контакта")]
        public void ContactCreationTest()
        {            
            applicationManager.Navigator.GoToNewContactPage();
            applicationManager.Contacts.FillContactForm(new ContactData("a", "a"));
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Logout();
        }
        [TestCase(TestName = "Создание пустого контакта")]
        public void EmptyContactCreationTest()
        {
            applicationManager.Navigator.GoToNewContactPage();
            applicationManager.Contacts.FillContactForm(new ContactData("", ""));
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Logout();
        }

    }
        
}
