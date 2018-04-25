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
            driver.FindElement(By.LinkText("groups")).Click();

            return new GroupHelper(driver);
        }

        public ContactHelper GoToContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();

            return new ContactHelper(driver);
        }
    }
}
