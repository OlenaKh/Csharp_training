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
            int id = 1;
            ContactData contact = new ContactData("111", "111");
            ContactData contactUpd = new ContactData("Salvador", "Dali");

            app.Navigation.GoToHomePage();


            if (app.Auth.IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + id + "]")))
            {
                app.Contacts.Modify(id, contactUpd);
            }
            else
            {
                app.Contacts.Create(contact);
                app.Contacts.Modify(id, contactUpd);
            }

        }
    }
}
