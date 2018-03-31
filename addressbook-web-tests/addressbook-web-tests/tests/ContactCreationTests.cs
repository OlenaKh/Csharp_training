using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
 
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Dmitriy","Fedorov");

            app.Contacts.Create(contact);
        }
    }
}

