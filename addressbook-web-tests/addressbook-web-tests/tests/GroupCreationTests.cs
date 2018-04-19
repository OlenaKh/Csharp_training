using System;
using System.Text;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData groupData = new GroupData("Test Group 1");
            groupData.Header = "Group Header";
            groupData.Footer = "Comment";
            
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Create(groupData);

            Assert.AreEqual(oldGroups.Count+1, app.Groups.GetGroupCount());

            List <GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(groupData);
            //Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData groupData = new GroupData("");
            groupData.Header = "";
            groupData.Footer = "";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Create(groupData);

            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(groupData);
            //Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
