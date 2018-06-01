﻿using System;
using NUnit.Framework;
using MySql.Data.MySqlClient;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            Int32 countBefore = appManager.ContactHelper.GetContactsCount();

            appManager.Navigation
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

            Assert.AreEqual(countBefore + 1, appManager.ContactHelper.GetContactsCount());
        }

        [Test]
        public void RemoveContactTest()
         {
            Int32 countBefore = appManager.ContactHelper.GetContactsCount();

            appManager.Navigation
                .GoToContactPage()
                .DeleteContactFromListById(1);

            appManager.Navigation
                .GoToContactPage();

            Assert.AreEqual(countBefore - 1, appManager.ContactHelper.GetContactsCount());
        }

        [Test]
        public void TestDbConnection()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=addressbook;Uid=root;Pwd=;charset=utf8;SslMode=none;");
            con.Open();
        }
    }
}
