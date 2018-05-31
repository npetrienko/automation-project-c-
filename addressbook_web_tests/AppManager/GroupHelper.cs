using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        IWebElement _newGroupButton => driver.FindElement(By.Name("new"));
        IWebElement _groupNameField => driver.FindElement(By.Name("group_name"));
        IWebElement _groupHeaderField => driver.FindElement(By.Name("group_header"));
        IWebElement _groupFooterField => driver.FindElement(By.Name("group_footer"));
        IWebElement _enterInformationButton => driver.FindElement(By.Name("submit"));
        IWebElement _deleteGroupButton => driver.FindElement(By.Name("delete"));

        public GroupHelper(IWebDriver driver) : base(driver) { }

        public GroupHelper InitGrouCreation()
        {
            _newGroupButton.Click();

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

            groupCache = null;

            return this;
        }

        public GroupHelper SelectGroupById(Int32 id)
        {
            driver.FindElement(By.XPath($"//form[@method='post']//span[{id + 1}]/input")).Click();

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
            groupCache = null;

            return this;
        }

        public GroupHelper Create(GroupData newGroup)
        {
            InitGrouCreation();
            FillGroupForm(newGroup);
            SubmitGroupCreation();

            return this;
        }

        private List<GroupData> groupCache = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();

                ICollection<IWebElement> elements = driver.FindElements(By.XPath("//span[@class='group']")).ToList();

                foreach (IWebElement element in elements)
                {
                    Int32 elementId = Int32.Parse(element.FindElement(By.TagName("input")).GetAttribute("value"));
                    groupCache.Add(new GroupData { Id = elementId, Name = element.Text });
                }
            }

            return new List<GroupData>(groupCache);
        }
    }
}
