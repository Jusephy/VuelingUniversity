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
    public class ProductPage : CommonPage
    {
        public ProductPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private IWebElement BtnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Add to cart']"); }
        }
        public ProductPage AddProductToCart()
        {
            BtnAddToCart.Click();
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = WebDriver.SwitchTo().Alert();
            alert.Accept();
            return this;
        }
    }
}
