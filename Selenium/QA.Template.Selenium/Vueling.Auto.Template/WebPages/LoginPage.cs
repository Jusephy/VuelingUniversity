using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class LoginPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        public LoginPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        public By Nameofuser
        {
            get { return By.Id("nameofuser"); }
        }
        public IWebElement NameOfUser
        {
            get { return WebDriver.FindElementById("nameofuser"); }
        }
        public IWebElement Username
        {
            get { return WebDriver.FindElementById("loginusername"); }
        }
        public IWebElement Password
        {
            get { return WebDriver.FindElementById("loginpassword"); }
        }
        public IWebElement SendLogIn
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Log in']"); }
        }
        public LoginPage Login()
        {
            var usernameText= "jusephy.paredes";
            var passwordText= "soytucontraseña1234";
            Username.SendKeys(usernameText);
            Password.SendKeys(passwordText);
            SendLogIn.Click();
            Thread.Sleep(1000);
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(Nameofuser));
            Assert.AreEqual(NameOfUser.Text,"Welcome "+usernameText);
            return this;
        }
    }
}
