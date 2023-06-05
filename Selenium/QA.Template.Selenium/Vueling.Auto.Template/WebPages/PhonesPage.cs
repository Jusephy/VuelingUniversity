using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class PhonesPage : CommonPage
    {
        public PhonesPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private IWebElement GetPhone (string phoneItemName)
        {//Samsung galaxy s6
            { return WebDriver.FindElementByXPath("//a[text()='"+phoneItemName+"']"); }
        }
        private IWebElement GetPhone2 (string phoneItemName2)
        {//Sony xperia z5
            { return WebDriver.FindElementByXPath("//a[text()='"+phoneItemName2+"']"); }
        }
        private IWebElement GetPhone3 (string phoneItemName3)
        {//Nokia lumia 1520
            { return WebDriver.FindElementByXPath("//a[text()='"+phoneItemName3+"']"); }
        }
        public PhonesPage GoToSelectedPhone (string phoneItemName)
        {
            GetPhone(phoneItemName).Click();
            return this;
        }
        public PhonesPage GoToSecondSelectedPhone (string phoneItemName2)
        {
            GetPhone2(phoneItemName2).Click();
            return this;
        }
        public PhonesPage GoToThirdSelectedPhone (string phoneItemName3)
        {
            GetPhone3(phoneItemName3).Click();
            return this;
        }

    }
}
