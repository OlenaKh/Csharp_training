using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData groupData = new GroupData("Test Group 1");
            groupData.Header = "Group Header";
            groupData.Footer = "Comment";

            appManager.Groups.Create(groupData);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData groupData = new GroupData("");
            groupData.Header = "";
            groupData.Footer = "";

            appManager.Groups.Create(groupData);
        }
    }
}