using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddNewContactTests : TestBase
    {
 
        [Test]
        public void AddNewContactTest()
        {
            ContactData contact = new ContactData("Dmitriy","Fedorov");

            appManager.Contacts.Create(contact);
        }
    }
}

