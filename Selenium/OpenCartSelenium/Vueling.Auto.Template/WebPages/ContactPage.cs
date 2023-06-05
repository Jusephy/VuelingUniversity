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
    public class ContactPage: CommonPage
    {
        public ContactPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
            get { return WebDriver.FindElementByCssSelector("input[type='submit']"); }
        }
        public ContactPage ContactForm(string name, string email, string enquiry)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ContactContainer));
            FieldName.SendKeys(name);
            FieldEmail.SendKeys(email);
            FieldEnquiry.SendKeys(enquiry);
            BtnSubmit.Click();
            return this;
        }
        public ContactPage ContactSuccesfully()
        {
            String currentURl = WebDriver.Url;
            string succesContact = "=information/contact/success";
            if (currentURl==currentURl+succesContact)
            {
                bool succes = true;
            }
            return this;
        }
    }
}
