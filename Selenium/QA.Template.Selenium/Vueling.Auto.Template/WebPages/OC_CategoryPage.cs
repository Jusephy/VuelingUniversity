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
    public class OC_CategoryPage : CommonPage
    {
        public OC_CategoryPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By ProductContainer
        {
            get { return By.Id("product-product"); }
        }
        private IWebElement ClickProduct(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='row'][4]//h4//a[text()='{productName}"); }
        }
        private IWebElement AddToCart(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='row'][4]//h4//a[text()='{productName}']/../../..//button[1]"); }
        }
        private IWebElement AddWishListProduct(string productName)
        {
            //{ return WebDriver.FindElementByXPath($"//div[@class='row'][4]//h4//a[text()='{productName}']/../../..//button[@data-original-title='Add to Wish List']"); }
            { return WebDriver.FindElementByXPath($"//div[@class='row'][4]//h4//a[text()='{productName}']/../../..//button[2]"); }
        }
        private IWebElement CompareProd(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='row'][4]//h4//a[text()='{productName}']/../../..//button[3]"); }
        }
        public OC_CategoryPage AddProductToCart(string productName)
        {
            AddToCart(productName).Click();
            return this;
        }
        public OC_CategoryPage AddProductToWishList(string productName)
        {
            AddWishListProduct(productName).Click();
            return this;
        }
        public OC_CategoryPage CompareProduct(string productName)
        {
            CompareProd(productName).Click();
            return this;
        }
    }
}
