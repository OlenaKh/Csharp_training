using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests.tests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Test Group Updated");
            newData.Header = "Updated Header";
            newData.Footer = "Updated Comment";

            appManager.Groups.Modify(1, newData);
        }

        [Test]
        public void GroupModificationEmptyRowTest()
        {
            GroupData newData = new GroupData("Group Updated with only Name");
            newData.Header = null;
            newData.Footer = null;

            appManager.Groups.Modify(1, newData);
        }
    }
}
