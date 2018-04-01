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
            int id = 1;
            GroupData groupData = new GroupData("New Group");
            groupData.Header = "123";
            groupData.Footer = "123";

            GroupData newData = new GroupData("Test Group Updated");
            newData.Header = "Updated Header";
            newData.Footer = "Updated Comment";

            app.Navigation.GoToGroupsPage();
            if (app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + id + "]")))
            {
                app.Groups.Modify(id, newData);
            }
            else
            {
                app.Groups.Create(groupData);
                app.Groups.Modify(id, newData);
            }
            
        }

        [Test]
        public void GroupModificationEmptyRowTest()
        {
            int id = 1;

            GroupData groupData = new GroupData("New Group");
            groupData.Header = "123";
            groupData.Footer = "123";

            GroupData newData = new GroupData("Group Updated with only Name");
            newData.Header = null;
            newData.Footer = null;

            app.Navigation.GoToGroupsPage();
            if (app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + id + "]")))
            {
                app.Groups.Modify(id, newData);
            }
            else
            {
                app.Groups.Create(groupData);
                app.Groups.Modify(id, newData);
            }
        }
    }
}
