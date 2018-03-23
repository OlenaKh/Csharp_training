using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class DeleteGroupTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            appManager.Groups.Remove(1);
        }
    }
}

