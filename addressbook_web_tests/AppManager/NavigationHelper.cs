using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private String baseURL;

        public NavigationHelper(IWebDriver driver, String baseURL) : base(driver)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }

        public GroupHelper GoToGroupPage()
        {
            if (driver.Url == $"{baseURL}addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return new GroupHelper(driver);
            }

            driver.Navigate().GoToUrl($"{baseURL}addressbook/group.php");

            return new GroupHelper(driver);
        }

        public ContactHelper GoToContactPage()
        {
            if (driver.Url == $"{baseURL}addressbook/edit.php"
                && IsElementPresent(By.Name("firstname")))
            {
                return new ContactHelper(driver);
            }

            driver.Navigate().GoToUrl($"{baseURL}addressbook/edit.php");

            return new ContactHelper(driver);
        }
    }
}
