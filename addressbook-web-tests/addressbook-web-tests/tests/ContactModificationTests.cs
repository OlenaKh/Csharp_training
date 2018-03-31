using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData contactUpd = new ContactData("Salvador", "Dali");

            app.Contacts.Modify(2, contactUpd);
        }
    }
}
