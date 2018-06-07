using System;
using NUnit.Framework;
using WebAddressbookTests.DataBase.TableModels;
using System.Collections.Generic;
using WebAddressbookTests.DataBase.TableRepositories;
using MySql.Data.MySqlClient;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            Int32 countBefore = _appManager.ContactHelper.GetContactsCount();

            _appManager.Navigation
                .GoToCreateContactPage()
                .FillContactForm(new ContactData
                    {
                        FirstName = "TestF",
                        LastName = "TestL",
                        NickName = "TestN",
                        Company = "TestCompany",
                        WorkTelephone = "0990367711",
                        Email_1 = "test.test@gmail.com"
                    })
                .SubmitContactCreation();

            Assert.AreEqual(countBefore + 1, _appManager.ContactHelper.GetContactsCount());
        }

        [Test]
        public void RemoveContactTest()
         {
            Int32 countBefore = _appManager.ContactHelper.GetContactsCount();

            _appManager.Navigation
                .GoToContactPage()
                .DeleteContactFromListById(1);

            _appManager.Navigation
                .GoToContactPage();

            Assert.AreEqual(countBefore - 1, _appManager.ContactHelper.GetContactsCount());
        }
    }
}
