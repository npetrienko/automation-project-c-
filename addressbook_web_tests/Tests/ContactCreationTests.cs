using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            appManager.Navigation
                .GoToContactPage()
                .FillContactForm(new ContactData("TestF", "TestL", "TestN", "TestCompany", "0990367766", "test.test@gmail.com"))
                .SubmitContactCreation();
        }
    }
}
