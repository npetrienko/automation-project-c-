using System;
using System.Text;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            appManager.Navigation
                .GoToGroupPage();

            List<GroupData> groupsBeforeDelete = appManager.GroupHelper.GetGroupList();

            appManager.GroupHelper
                .SelectGroupById(0)
                .RemoveGroup();

            appManager.Navigation
                .GoToGroupPage();

            Assert.AreNotEqual(groupsBeforeDelete, appManager.GroupHelper.GetGroupList());
        }
    }
}
