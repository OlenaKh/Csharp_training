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
            int id = 0;
            ContactData contact = new ContactData("101", "101");

            app.Navigation.GoToHomePage();
            if (!app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (id + 1) + "]")))
            {
                app.Contacts.Create(contact);
            }

            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            app.Contacts.Remove(id);
            List<ContactData> newContacts = app.Contacts.GetContactsList();
            oldContacts.RemoveAt(id);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
