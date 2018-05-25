using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        IWebElement _firstNameField => driver.FindElement(By.Name("firstname"));
        IWebElement _lastNameField => driver.FindElement(By.Name("lastname"));
        IWebElement _nickNameField => driver.FindElement(By.Name("nickname"));
        IWebElement _companyField => driver.FindElement(By.Name("company"));
        IWebElement _workTelephoneField => driver.FindElement(By.Name("work"));
        IWebElement _firstEmailField => driver.FindElement(By.Name("email"));
        IWebElement _enterButton => driver.FindElement(By.Name("submit"));
        IWebElement _deleteButton => driver.FindElement(By.XPath("//input[@value='Delete']"));
        IWebElement _deleteMessage => driver.FindElement(By.ClassName("msgbox"));
        IWebElement _contactsCount => driver.FindElement(By.Id("search_count"));

        public ContactHelper(IWebDriver driver) : base(driver) { }

        public ContactHelper FillContactForm(ContactData contact)
        {
            _firstNameField.Type(contact.FirstName);
            _lastNameField.Type(contact.LastName);
            _nickNameField.Type(contact.NickName);
            _companyField.Type(contact.Company);
            _workTelephoneField.Type(contact.WorkTelephone);
            _firstNameField.Type(contact.Email_1);

            return this;
        }

        public void SubmitContactCreation()
        {
            _enterButton.Click();
            wait.WaitForElementImplicitly(By.Id("search_count"));
        }

        private void SelectContactFromListById(Int32 id)
        {
            driver.FindElement(By.XPath($"//tr[@name='entry'][{id}]//input")).Click();
        }

        private void SelectContactFromListByEmail(String email)
        {
            driver.FindElement(By.XPath($"//input[@accept='{email}']")).Click();
        }

        public void DeleteContactFromListById(Int32 id)
        {
            SelectContactFromListById(id);
            _deleteButton.Click();

            driver.SwitchTo().Alert().Accept();
        }

        public void DeleteContactFromListByEmail(String email)
        {
            SelectContactFromListByEmail(email);
            _deleteButton.Click();

            driver.SwitchTo().Alert().Accept();
        }

        public Int32 GetContactsCount()
        {
            return Int32.Parse(_contactsCount.Text);
        }
    }
}
