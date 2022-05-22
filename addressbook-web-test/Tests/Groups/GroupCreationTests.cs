using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests : AuthBaseTest
    {
        [TestCase(TestName = "Добавление группы a a")]
        public void GroupCreationTest()
        {

            GroupData group = new GroupData("a");
            group.Header = "a";
            group.Footer = "a";
            applicationManager.Groups.Create(group);
        }

        [TestCase(TestName = "Добавление группы")]
        public void EmptyGroupCreationTest()
        {

            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            applicationManager.Groups.Create(group);
        }
    }
}