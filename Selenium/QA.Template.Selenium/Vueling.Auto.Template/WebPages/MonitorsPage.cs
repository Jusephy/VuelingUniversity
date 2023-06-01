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
    public class MonitorsPage : CommonPage
    {
        public MonitorsPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private IWebElement GetMonitor
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Apple monitor 24']"); }
        }
        private IWebElement GetMonitor2
        {
            get { return WebDriver.FindElementByXPath("//a[text()='ASUS Full HD']"); }
        }
        //añadir un artículo de la página actual al cart
        //volver a la página de portátiles, ir a la página siguiente
        //añadir una la`ptop diferente
        public MonitorsPage GoToSelectedMonitor()
        {
            GetMonitor.Click();
            return this;
        }
        public MonitorsPage GoToSecondSelectedMonitor()
        {
            GetMonitor2.Click();
            return this;
        }

    }
}
