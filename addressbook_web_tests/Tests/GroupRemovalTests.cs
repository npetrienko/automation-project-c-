using System;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            appManager.Navigation
                .GoToGroupPage()
                .SelectGroupById(5)
                .RemoveGroup();

            appManager.Navigation
                .GoToGroupPage();
        }
    }
}
