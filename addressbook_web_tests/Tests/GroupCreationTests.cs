using System;
using System.Text;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        static IEnumerable<GroupData> testData = TestDataProvider.GetGroupDataFromFile();

        [Test, TestCaseSource("testData")]
        public void GroupCreationTest(GroupData group)
        {
            _appManager.Navigation
                .GoToGroupPage();

            List<GroupData> existingGroups = _appManager.GroupHelper.GetGroupList();

            _appManager.GroupHelper
                .Create(group);

            _appManager.Navigation
                .GoToGroupPage();

            Assert.AreEqual(existingGroups.Count + 1, _appManager.GroupHelper.GetGroupList().Count);
        }
    }
}
