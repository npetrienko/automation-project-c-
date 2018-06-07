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
            _appManager.Navigation
                .GoToGroupPage();

            List<GroupData> groupsBeforeDelete = _appManager.GroupHelper.GetGroupList();

            _appManager.GroupHelper
                .SelectGroupById(0)
                .RemoveGroup();

            _appManager.Navigation
                .GoToGroupPage();

            Assert.AreNotEqual(groupsBeforeDelete, _appManager.GroupHelper.GetGroupList());
        }
    }
}
