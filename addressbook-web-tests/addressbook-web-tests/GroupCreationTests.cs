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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            GroupData groupData = new GroupData("Test Group 1");
            groupData.Header = "Group Header";
            groupData.Footer = "Comment";
            FillGroupForm(groupData);
            SubmitGroupCreation();
            ReturnToGroupsPage();
        }
    }
}