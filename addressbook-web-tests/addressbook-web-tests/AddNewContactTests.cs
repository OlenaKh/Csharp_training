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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitNewContactCreation();
            ContactData contact = new ContactData("Dmitriy","Fedorov");
            FillContactCreationForm(contact);
            SubmitContactCreation();
            Logout();
        }
    }
}

