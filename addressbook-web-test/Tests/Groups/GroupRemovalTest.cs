using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupRemovalTests : AuthBaseTest

    {
        [Test]
        public void GroupRemovalTest()
        {
            applicationManager.Groups.Remove();
        }
    }
}
