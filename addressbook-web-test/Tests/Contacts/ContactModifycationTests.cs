using NUnit.Framework;
using System.Collections.Generic;

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
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            applicationManager.Contacts.ContactModification(0, newData);
            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            oldContact[0].Lastname = newData.Lastname;
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
        }

        [TestCase(TestName = "Изменение контакта пустые значения")]
        public void ContactModificationTestNULL()
        {
            ContactData newData = new ContactData("rae");
            newData.Firstname = "null";
            newData.Lastname = "null";
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            applicationManager.Contacts.ContactModification(0, newData);
            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            oldContact[0].Firstname = newData.Firstname;
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
        }
    }
}
