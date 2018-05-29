using System;
using System.Text;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        public static IEnumerable<GroupData> RandomGroupDataProvider()
        {
            Random rnd = new Random();

            List<GroupData> groups = new List<GroupData>();

            for(Int32 i = 0; i < 5; i++)
            {
                Int32 randValue = rnd.Next(1000);

                groups.Add(new GroupData
                {
                    Name = $"New group name {randValue}",
                    Header = $"New group header {randValue}",
                    Footer = $"New group footer {randValue}"
                });
            }

            return groups;
        }

        [Test, TestCaseSource("RandomGroupDataProvider")]
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
