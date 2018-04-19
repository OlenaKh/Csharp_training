using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests.tests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            int id = 0;
            GroupData groupData = new GroupData("New Group");
            groupData.Header = "123";
            groupData.Footer = "123";

            GroupData newData = new GroupData("Test Group Updated");
            newData.Header = "Updated Header";
            newData.Footer = "Updated Comment";

            app.Navigation.GoToGroupsPage();
            if (!app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (id + 1) + "]")))
            {
                app.Groups.Create(groupData);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Modify(id, newData);

            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[id].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void GroupModificationEmptyRowTest()
        {
            int id = 0;

            GroupData groupData = new GroupData("New Group");
            groupData.Header = "123";
            groupData.Footer = "123";

            GroupData newData = new GroupData("Group Updated with only Name");
            newData.Header = null;
            newData.Footer = null;

            app.Navigation.GoToGroupsPage();
            if (!app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (id +1) + "]")))
            {
                app.Groups.Create(groupData);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Modify(id, newData);

            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[id].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
