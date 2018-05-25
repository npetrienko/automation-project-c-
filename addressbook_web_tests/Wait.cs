using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class Wait
    {
        private IWebDriver _driver;
        private static WebDriverWait _wait;

        public Wait(IWebDriver driver)
        {
            _driver = driver;
        } 

        public void WaitForElementExplicitly(By selector)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement element = _wait.Until<IWebElement>(d => d.FindElement(selector));
        }

        public void WaitForElementImplicitly(By selector)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement element = _driver.FindElement(selector);
        }
    }
}
