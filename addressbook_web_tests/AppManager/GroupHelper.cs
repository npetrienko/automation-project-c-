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
        IWebElement _groupNameField => driver.FindElement(By.Name("group_name"));
        IWebElement _groupHeaderField => driver.FindElement(By.Name("group_header"));
        IWebElement _groupFooterField => driver.FindElement(By.Name("group_footer"));
        IWebElement _enterInformationButton => driver.FindElement(By.Name("submit"));
        IWebElement _deleteGroupButton => driver.FindElement(By.Name("delete"));

        public GroupHelper(IWebDriver driver) : base(driver) { }

        public GroupHelper InitGrouCreation()
        {
            driver.FindElement(By.Name("new")).Click();

            return this;
        }

        public GroupHelper FillGroupForm(GroupData newGroup)
        {
            _groupNameField.Type(newGroup.Name);
            _groupHeaderField.Type(newGroup.Header);
            _groupFooterField.Type(newGroup.Footer);

            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            _enterInformationButton.Click();

            return this;
        }

        public GroupHelper SelectGroupById(Int32 id)
        {
            driver.FindElement(By.XPath($"//span/input[@value='2{id}']")).Click();

            return this;
        }

        public GroupHelper SelectGroupByName(String name)
        {
            driver.FindElement(By.XPath($"//span/input[@title='Select ({name})']")).Click();

            return this;
        }

        public GroupHelper RemoveGroup()
        {
            _deleteGroupButton.Click();

            return this;
        }

        public GroupHelper Create(GroupData newGroup)
        {
            InitGrouCreation();
            FillGroupForm(newGroup);
            SubmitGroupCreation();

            return this;
        }
    }
}
