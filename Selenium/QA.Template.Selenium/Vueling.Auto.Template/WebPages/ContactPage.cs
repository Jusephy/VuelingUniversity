using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class ContactPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        public ContactPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        private IWebElement contactEmail
        {
            get { return WebDriver.FindElement(By.Id("recipient-email")); }
        }
        private IWebElement contactName
        {
            get { return WebDriver.FindElement(By.Id("recipient-name")); }
        }
        private IWebElement contactMessage
        {
            get { return WebDriver.FindElement(By.Id("message-text")); }
        }
        private IWebElement btnSendMessage
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Send message']"); }
        }
        public ContactPage FillContact()
        {
            contactEmail.SendKeys("prubatesting@yopmail.com");
            contactName.SendKeys("Laporta");
            contactMessage.SendKeys("Messi vuelve al Barça\nPD:Esto es un testing, no te rayes");
            btnSendMessage.Click();
            Thread.Sleep(2000);
            return this;
        }
    }
}
