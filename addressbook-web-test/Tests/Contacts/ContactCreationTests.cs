using NUnit.Framework;
using System.Collections.Generic;



namespace addressbook_web_test
{
    [TestFixture]
    public class ContactCreationTests : AuthBaseTest
    {
        
        [TestCase(TestName = "Создание контакта")]
        public void ContactCreationTest()
        {
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            applicationManager.Contacts.ContactCreate(new ContactData("a", "a"));
            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            Assert.AreEqual(oldContact.Count + 1, newContact.Count);
        }
        [TestCase(TestName = "Создание пустого контакта")]
        public void EmptyContactCreationTest()
        {
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            applicationManager.Contacts.ContactCreate(new ContactData("", ""));
            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            Assert.AreEqual(oldContact.Count + 1, newContact.Count);
        }
        [TestCase(TestName = "Некорректный символ в имени контакта")]
        public void BadNameContactCreationTest()
        {
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            applicationManager.Contacts.ContactCreate(new ContactData("a'a", ""));
            List <ContactData> newContact = applicationManager.Contacts.GetContactList();
            Assert.AreEqual(oldContact.Count + 1, newContact.Count);
        }


    }
        
}
