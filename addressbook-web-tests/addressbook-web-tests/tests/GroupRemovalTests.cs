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
            int id = 1;
            GroupData groupData = new GroupData("New Group");
            groupData.Header = "123";
            groupData.Footer = "123";


            app.Navigation.GoToGroupsPage();
            if (app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + id + "]")))
            {
                app.Groups.Remove(id);
            }
            else
            {
                app.Groups.Create(groupData);
                app.Groups.Remove(id);
            }
   
        }
    }
}
