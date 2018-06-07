using OpenQA.Selenium;
using System;

namespace WebAddressbookTests

{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected Wait wait;

        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
            wait = new Wait(driver);
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