using OpenQA.Selenium;
using System;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;

        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Boolean IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

    }
}