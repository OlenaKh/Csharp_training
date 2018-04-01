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
    public class ContactRemovalTests : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            int id = 1;
            ContactData contact = new ContactData("111", "111");

            app.Navigation.GoToHomePage();

            if (app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + id + "]")))
            {
                app.Contacts.Remove(id);
            }
            else
            {
                app.Contacts.Create(contact);
                app.Contacts.Remove(id);
            }
        }
    }
}
