using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class DeleteGroupTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
        }
    }
}

