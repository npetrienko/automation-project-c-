using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public IWebElement GroupNameField
        {
            get { return this.driver.FindElement(By.Name("group_name")); }
        }

        IWebElement groupNameField => driver.FindElement(By.Name("group_name"));


        public GroupHelper(IWebDriver driver) : base(driver) { }

        public GroupHelper InitGrouCreation()
        {
            driver.FindElement(By.Name("new")).Click();

            return this;
        }

        public GroupHelper FillGroupForm(GroupData newGroup)
        {
           // _groupNameField = driver.FindElement(By.Name("group_name"));

            groupNameField.Type(newGroup.Name);

            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(newGroup.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(newGroup.Footer);

            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();

            return this;
        }

        public GroupHelper SelectGroup()
        {
            driver.FindElement(By.XPath("//span[1]/input")).Click();

            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();

            return this;
        }

        public GroupHelper Create(GroupData newGroup)
        {
            InitGrouCreation();
            FillGroupForm(newGroup);
            SubmitGroupCreation();

            return this;
        }

        private const String GROUP_NAME_FIELD = "group_name";
    }
}
