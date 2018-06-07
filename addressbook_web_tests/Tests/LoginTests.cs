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

            _appManager.Auth.LogOut();

            _appManager.Auth.Login(account);

            Assert.IsTrue(_appManager.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            AccountData account = new AccountData
            {
                UserName = "admin",
                Password = "secr"
            };

            _appManager.Auth.LogOut();

            _appManager.Auth.Login(account);

            Assert.IsFalse(_appManager.Auth.IsLoggedIn());
        }
    }
}
