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
    public class LaptopsPage : CommonPage
    {
        public LaptopsPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private IWebElement GetLaptop
        {
            get { return WebDriver.FindElementByXPath("//a[text()='MacBook air']"); }
        }
        private IWebElement GetLaptop2
        {
            get { return WebDriver.FindElementByXPath("//a[text()='MacBook Pro']"); }
        }
        private IWebElement IdNext2Page
        {
            get { return WebDriver.FindElementById("next2"); }
        }
        //añadir un artículo de la página actual al cart
        //volver a la página de portátiles, ir a la página siguiente
        //añadir una la`ptop diferente
        public LaptopsPage GoToSelectedLaptop()
        {
            GetLaptop.Click();
            return this;
        }
        public LaptopsPage GoToSecondPage()
        {
            IdNext2Page.Click();
            return this;
        }
        public LaptopsPage GoToSecondSelectedLaptop()
        {
            GetLaptop2.Click();
            return this;
        }

    }
}
