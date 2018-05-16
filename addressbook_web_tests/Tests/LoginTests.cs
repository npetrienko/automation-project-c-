using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            AccountData account = new AccountData
            {
                UserName = "admin",
                Password = "secret"
            };

            appManager.Auth.LogOut();

            appManager.Auth.Login(account);

            Assert.IsTrue(appManager.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            AccountData account = new AccountData
            {
                UserName = "admin",
                Password = "secr"
            };

            appManager.Auth.LogOut();

            appManager.Auth.Login(account);

            Assert.IsFalse(appManager.Auth.IsLoggedIn());
        }
    }
}
