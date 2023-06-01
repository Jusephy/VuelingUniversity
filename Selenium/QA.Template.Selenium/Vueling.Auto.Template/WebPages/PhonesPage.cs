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
        {
            { return WebDriver.FindElementByXPath("//a[text()='"+phoneItemName+"']"); }
        }
        private IWebElement GetPhone2
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Sony xperia z5']"); }
        }
        private IWebElement GetPhone3
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Nokia lumia 1520']"); }
        }
        //añadir un artículo de la página actual al cart
        //volver a la página de portátiles, ir a la página siguiente
        //añadir una la`ptop diferente
        public PhonesPage GoToSelectedPhone(string phoneItemName)
        {
            GetPhone(phoneItemName).Click();
            return this;
        }
        public PhonesPage GoToSecondSelectedPhone()
        {
            GetPhone2.Click();
            return this;
        }
        public PhonesPage GoToThirdSelectedPhone()
        {
            GetPhone3.Click();
            return this;
        }

    }
}
