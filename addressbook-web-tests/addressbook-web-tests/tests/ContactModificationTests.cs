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
    public class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            int id = 0;
            ContactData contact = new ContactData("111", "111");
            ContactData contactUpd = new ContactData("Salvador", "Dali");

            app.Navigation.GoToHomePage();
            if (!app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (id + 1) + "]")))
            {
                app.Contacts.Create(contact);
            }

            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            app.Contacts.Modify(id, contactUpd);
            List<ContactData> newContacts = app.Contacts.GetContactsList();
            oldContacts[id].Lastname = contactUpd.Lastname;
            oldContacts[id].Firstname = contactUpd.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

        }
    }
}
