using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        IWebElement _userNameField => driver.FindElement(By.Name("user"));
        IWebElement _userPasswordField => driver.FindElement(By.Name("pass"));
        IWebElement _submitButton => driver.FindElement(By.CssSelector("input[type=\"submit\"]"));
        IWebElement _loggedInUserName => driver.FindElement(By.CssSelector(".header>b"));
        IWebElement _logOutButton => driver.FindElement(By.CssSelector(".header>a"));

        public LoginHelper(IWebDriver driver) : base(driver) { }

        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }

                LogOut();
            }

            _userNameField.Type(account.UserName);
            _userPasswordField.Type(account.Password);
            _submitButton.Click();
        }

        public Boolean IsLoggedIn()
        {
            return IsElementPresent(By.CssSelector(".header>a"));
        }

        public Boolean IsLoggedIn(AccountData account)
        {
            return _loggedInUserName.Text == $"({account.UserName})";
        }

        public void LogOut()
        {
            if (IsLoggedIn())
            {
                _logOutButton.Click();
            }
        }
    }
}
