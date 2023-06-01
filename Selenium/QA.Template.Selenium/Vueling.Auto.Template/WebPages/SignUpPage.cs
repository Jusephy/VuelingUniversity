using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
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
    public class SignUpPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        public SignUpPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
        public IWebElement SignUpUsername
        {
            get { return WebDriver.FindElementById("sign-username"); }
        }
        public IWebElement SignUpPassword
        {
            get { return WebDriver.FindElementById("sign-password"); }
        }
        public IWebElement SendSignUp
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Sign up']"); }
        }
        public SignUpPage Signup()
        {
            //Username.SendKeys("jusephy.paredes");
            //Password.SendKeys("soytucontraseña1234");
            SignUpUsername.SendKeys("jusephy");
            SignUpPassword.SendKeys("soytucontraseña1234");
            SendSignUp.Click();
            Thread.Sleep(1000);
            return this;
        }
    }
}
