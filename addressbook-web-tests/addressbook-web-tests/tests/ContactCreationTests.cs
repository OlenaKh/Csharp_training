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
    public class ContactCreationTests : AuthTestBase
    {
 
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Dmitriy","Fedorov");

            app.Navigation.GoToHomePage();
            app.Contacts.Create(contact);
        }
    }
}

