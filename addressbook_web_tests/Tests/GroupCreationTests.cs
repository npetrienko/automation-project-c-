using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData
            (
                "New group name", "New group header", "New group footer"
            );

            appManager.Navigation
                .GoToGroupPage()
                .Create(group);

            appManager.Navigation
                .GoToGroupPage();
        }
    }
}
