using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupModificationTests : AuthBaseTest
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("aer");
            newData.Header = "aer";
            newData.Footer = "aer";
            applicationManager.Groups.Modify(1, newData);

        }

        [Test]
        public void GroupModificationTestNULL()
        {
            GroupData newData = new GroupData("aer");
            newData.Header = "null";
            newData.Footer = "null";
            applicationManager.Groups.Modify(1, newData);
        }
    }
}
