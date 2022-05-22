using NUnit.Framework;


namespace addressbook_web_test
{
    [TestFixture]
    public class ContactsRemovalTests : AuthBaseTest
    {
        [TestCase(TestName = "Удаление контакта")]
        public void ContactsRemovalTest()
        {
            applicationManager.Contacts.Delete();
        }
    }
}
