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
            ContactData contactData = new ContactData("101", "101");

            app.Navigation.GoToHomePage();
            if (!app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (id + 1) + "]")))
            {
                app.Contacts.Create(contactData);
            }

            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            app.Contacts.Remove(id);

            Assert.AreEqual(oldContacts.Count - 1, app.Contacts.GetContactsCount());

            List<ContactData> newContacts = app.Contacts.GetContactsList();
            ContactData toBeRemoved = oldContacts[id];
            oldContacts.RemoveAt(id);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts)
            {
                Assert.AreNotEqual(contact.Id, toBeRemoved.Id);
            }

        }
    }
}
