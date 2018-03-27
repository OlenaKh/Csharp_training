using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
 
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Dmitriy","Fedorov");

            appManager.Contacts.Create(contact);
        }
    }
}

