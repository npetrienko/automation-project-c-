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
