using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class ContactModifycationTests : AuthBaseTest
    {
        [TestCase(TestName = "Изменение контакта")]
        public void ContactModificationTest() 
        {
            applicationManager.Contacts.ContactModification(new ContactData("rae","rae"));
        }
    }
}
