using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class OC_LoginPage : CommonPage
    {
        public OC_LoginPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By AccountLoginContainer
        {
            get { return By.Id("account-login"); }
        }
        private IWebElement FieldEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
        private IWebElement FieldPassword
        {
            get { return WebDriver.FindElementById("input-password"); }
        }
        private IWebElement BtnLogin
        {
            get { return WebDriver.FindElementByCssSelector("//input[@value='Login']"); }
        }
        public OC_LoginPage LoginUser(string email, string password)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(AccountLoginContainer));
            FieldEmail.SendKeys(email);
            FieldPassword.SendKeys(password);
            BtnLogin.Click();
            return this;
        }
    }
}
