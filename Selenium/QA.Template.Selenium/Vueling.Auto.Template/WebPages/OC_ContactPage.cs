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
    public class OC_ContactPage: CommonPage
    {
        public OC_ContactPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By ContactContainer
        {
            get { return By.Id("information-contact"); }
        }
        private IWebElement FieldName
        {
            get { return WebDriver.FindElementById("input-name"); }
        }
        private IWebElement FieldEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
        private IWebElement FieldEnquiry
        {
            get { return WebDriver.FindElementById("input-enquiry"); }
        }
        private IWebElement BtnSubmit
        {
            get { return WebDriver.FindElementByCssSelector("//input[@type='submit']"); }
        }
        public OC_ContactPage ContactForm(string name, string email, string enquiry)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ContactContainer));
            FieldName.SendKeys(name);
            FieldEmail.SendKeys(email);
            FieldEnquiry.SendKeys(enquiry);
            BtnSubmit.Click();
            return this;
        }
    }
}
