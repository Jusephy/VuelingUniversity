using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Support.Events;
using Demoblaze.Auto.Template.WebPages;
using Demoblaze.Auto.Template.SetUp;
using OpenQA.Selenium;
using Demoblaze.Auto.Template.Common;
using OpenQA.Selenium.Support.UI;
using System;

namespace Demoblaze.Auto.Template.Tests
{
    [TestFixture]
    internal class DemoTests : TestSetCleanBase
    {
        /*[TestCase]
        public void SignUpTest()
        {
            homePage = new HomePage(setUpWebDriver);
            signupPage = new SignUpPage(setUpWebDriver);
            homePage.GoToSingUp();
            signupPage.Signup();
        }*/
        [TestCase]
        public void ContactTest()
        {
            test.Log(Status.Debug, "Entra en Demoblaze.");
            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Clica en Categories-> Phones.");
            homePage.ClickToContact();
            test.Log(Status.Debug, "Clica en Contact");
            contactPage.FillContact();
            test.Log(Status.Debug, "Rellenar Contact Message");
            test.Log(Status.Debug, "Enviar Message");
            test.Log(Status.Pass, "Fin del test.");
        }
        [TestCase]
        public void CartTest()
        {
            //homePage = new HomePage(setUpWebDriver);
            //test.Log(Status.Debug, "Entra en Demoblaze.");
            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Clica en Categories-> Phones.");
            //homePage.;
            test.Log(Status.Debug, "Clica en Samsung Galaxy S6");
            test.Log(Status.Debug, "Añadir al carrito");
            test.Log(Status.Debug, "Volver a la página anterior");
            test.Log(Status.Debug, "Clica en Samsung Galaxy S6");
            test.Log(Status.Debug, "Enviar Message");
            test.Log(Status.Pass, "Fin del test.");
        }
    }
}