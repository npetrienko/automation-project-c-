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
                .SelectGroup()
                .RemoveGroup();

            appManager.Navigation
                .GoToGroupPage();
        }
    }
}
