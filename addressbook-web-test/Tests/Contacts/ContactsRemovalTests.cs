using NUnit.Framework;
using System.Collections.Generic;


namespace addressbook_web_test
{
    [TestFixture]
    public class ContactsRemovalTests : AuthBaseTest
    {
        [TestCase(TestName = "Удаление контакта")]
        public void ContactsRemovalTest()
        {
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();

            applicationManager.Contacts.Delete();

            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            oldContact.RemoveAt(0);
            Assert.AreEqual(oldContact, newContact);

        }
    }
}
