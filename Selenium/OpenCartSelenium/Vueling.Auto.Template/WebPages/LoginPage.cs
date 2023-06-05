using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class LoginPage : CommonPage
    {
        public LoginPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
            get { return WebDriver.FindElementByXPath("//input[@value='Login']"); }
        }
        public LoginPage LoginUser(string email, string password)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(AccountLoginContainer));
            FieldEmail.SendKeys(email);
            FieldPassword.SendKeys(password);
            BtnLogin.Click();
            return this;
        }
    }
}
