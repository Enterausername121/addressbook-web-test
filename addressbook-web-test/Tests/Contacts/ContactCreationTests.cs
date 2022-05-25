using NUnit.Framework;



namespace addressbook_web_test
{
    [TestFixture]
    public class ContactCreationTests : AuthBaseTest
    {
        
        [TestCase(TestName = "Создание контакта")]
        public void ContactCreationTest()
        {            
            
            applicationManager.Contacts.ContactCreate(new ContactData("a", "a"));

        }
        [TestCase(TestName = "Создание пустого контакта")]
        public void EmptyContactCreationTest()
        {
            
            applicationManager.Contacts.ContactCreate(new ContactData("", ""));
         
        }

    }
        
}
