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
            ContactData contact = new ContactData("");
            contact.Firstname = "a";
            contact.Lastname = "a";
            applicationManager.Contacts.ContactCreate(contact);
            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            oldContact.Add(contact);
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
        }
        [TestCase(TestName = "Создание пустого контакта")]
        public void EmptyContactCreationTest()
        {
            
            ContactData contact = new ContactData("");
            contact.Firstname = "";
            contact.Lastname = "";
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            applicationManager.Contacts.ContactCreate(contact);
            List<ContactData> newContact = applicationManager.Contacts.GetContactList();
            oldContact.Add(contact);
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
        }

        [TestCase(TestName = "Некорректный символ в имени контакта")]
        public void BadNameContactCreationTest()
        {
            List<ContactData> oldContact = applicationManager.Contacts.GetContactList();
            ContactData contact = new ContactData("a'a");
            contact.Firstname = "a'a";
            contact.Lastname = "";
            applicationManager.Contacts.ContactCreate(contact);
            List <ContactData> newContact = applicationManager.Contacts.GetContactList();
            oldContact.Add(contact);
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
        }


    }
        
}
