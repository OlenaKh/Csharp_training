using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class DeleteGroupTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            int id = 0;
            GroupData groupData = new GroupData("New Group");
            groupData.Header = "123";
            groupData.Footer = "123";


            app.Navigation.GoToGroupsPage();
            if (!app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (id + 1) + "]")))
            {
                app.Groups.Create(groupData);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(id);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(id);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
