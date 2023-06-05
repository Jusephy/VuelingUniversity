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
        private IWebElement GetLaptop (string laptopItemName)
        {//MacBook air
            { return WebDriver.FindElementByXPath("//a[text()='"+laptopItemName+"']"); }
        }
        private IWebElement GetLaptop2 (string laptopItemName2)
        {//MacBook Pro
            { return WebDriver.FindElementByXPath("//a[text()='"+laptopItemName2+"']"); }
        }
        private IWebElement IdNext2Page
        {
            get { return WebDriver.FindElementById("next2"); }
        }
        //añadir un artículo de la página actual al cart
        //volver a la página de portátiles, ir a la página siguiente
        //añadir una la`ptop diferente
        public LaptopsPage GoToSelectedLaptop(string laptopItemName)
        {
            GetLaptop(laptopItemName).Click();
            return this;
        }
        public LaptopsPage GoToSecondPage()
        {
            IdNext2Page.Click();
            return this;
        }
        public LaptopsPage GoToSecondSelectedLaptop(string laptopItemName2)
        {
            GetLaptop2(laptopItemName2).Click();
            return this;
        }

    }
}
