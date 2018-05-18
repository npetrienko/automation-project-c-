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
            Int32 randValue = new Random().Next(1000);

            GroupData group = new GroupData
            {
                Name = $"New group name {randValue}",
                Header = $"New group header {randValue}",
                Footer = $"New group footer {randValue}"
            };

            appManager.Navigation
                .GoToGroupPage();

            List<GroupData> existingGroups = appManager.GroupHelper.GetGroupList();

            appManager.GroupHelper
                .Create(group);

            appManager.Navigation
                .GoToGroupPage();

            Assert.AreEqual(existingGroups.Count + 1, appManager.GroupHelper.GetGroupList().Count);
        }
    }
}
