using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class ContactModifycationTests : AuthBaseTest
    {       
        [TestCase(TestName = "Изменение контакта")]
        public void ContactModificationTest() 
        {
            ContactData newData = new ContactData("rae");
            newData.Firstname = "rae";
            newData.Lastname = "rae";
            applicationManager.Contacts.ContactModification(1, newData);
        }

        [TestCase(TestName = "Изменение контакта пустые значения")]
        public void ContactModificationTestNULL()
        {
            ContactData newData = new ContactData("rae");
            newData.Firstname = "null";
            newData.Lastname = "null";
            applicationManager.Contacts.ContactModification(1, newData);
        }
    }
}
