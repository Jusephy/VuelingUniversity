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
    public class CartPage : CommonPage
    {
        public CartPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By ProductContainer
        {
            get { return By.Id("product-product"); }
        }
        private IWebElement GetUnitPrice (string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='table-responsive']//a[text()='{productName}']/../../td[5]"); }
        }
        private IWebElement GetTotalPrice (string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='table-responsive']//a[text()='{productName}']/../../td[6]"); }
        }
        private IWebElement FieldUpdateQty
        {
            get { return WebDriver.FindElementByXPath("//input[@name='quantity[214342]']"); }
        }
        private IWebElement BtnUpdate (string productName)
        {
            //get { return WebDriver.FindElementByXPath("//button[@data-original-title='Update']"); }
            //{ return WebDriver.FindElementByXPath($"//div[@class='table-responsive']//a[text()='{productName}']/../../td[4]"); }
            { return WebDriver.FindElementByXPath($"//div[@class='table-responsive']//a[text()='{productName}']/../../td//span/button[@data-original-title='Update']"); }
        }
        private IWebElement BtnRemove (string productName)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='table-responsive']//a[text()='{productName}']/../../td//span/button[@data-original-title='Remove']"); }
        }
        private IWebElement BtnContinueShopping
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue Shopping']"); }
        }
        private IWebElement BtnCheckout
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Checkout']"); }
        }
        public CartPage UpdateQuantity(int updateQuantity, string productName)
        {
            FieldUpdateQty.Clear();
            FieldUpdateQty.SendKeys(updateQuantity.ToString());
            BtnUpdate(productName).Click();
            return this;
        }
        public CartPage RemoveProduct(string productName)
        {
            BtnRemove(productName).Click();
            return this;
        }
        public CartPage ContinueShopping()
        {
            BtnContinueShopping.Click();
            return this;
        }
        public CartPage MakeCheckout()
        {
            BtnCheckout.Click();
            return this;
        }
    }
}
