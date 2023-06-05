using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class CategoryPage : CommonPage
    {
        public CategoryPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By ProductContainer
        {
            get { return By.Id("product-product"); }
        }
        private IWebElement SelectProduct(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='row']//h4//a[text()='{productName}']"); }
        }
        private IWebElement SelectPhone(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='caption']//h4//a[text()='{productName}']"); }
        }
        private IWebElement ToCart(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='row']//h4//a[text()='{productName}']/../../..//button[1]"); }
        }
        private IWebElement PhoneToCart(string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='caption']//h4//a[text()='{productName}']/../../../div[@class='button-group']//span[text()='Add to Cart']"); }
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
        public CategoryPage ClickProduct(string productName)
        {
            SelectProduct(productName).Click();
            return this;
        }
        public CategoryPage ClickPhone(string productName)
        {
            SelectPhone(productName).Click();
            return this;
        }
        public CategoryPage AddProductToCart(string productName)
        {
            ToCart(productName).Click();
            return this;
        }
        public CategoryPage AddPhoneToCart(string productName)
        {
            PhoneToCart(productName).Click();
            return this;
        }
        public CategoryPage AddProductToWishList(string productName)
        {
            AddWishListProduct(productName).Click();
            return this;
        }
        public CategoryPage CompareProduct(string productName)
        {
            CompareProd(productName).Click();
            return this;
        }
    }
}
