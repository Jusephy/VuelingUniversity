using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class ProductPage : CommonPage
    {
        public ProductPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By ProductContainer
        {
            get { return By.Id("product-product"); }
        }
        private IWebElement ProductName
        {
            get { return WebDriver.FindElementByXPath("//div[@class='col-sm-4']/h1"); }
        }
        private IWebElement ProductPrice
        {
            get { return WebDriver.FindElementByXPath("//ul[@class='list-unstyled']//h2"); }
        }
        private IWebElement RadioOptions
        {
            get { return WebDriver.FindElementByXPath("//div[@class='radio']//input"); }
        }
        private IWebElement CheckboxOptions (int optionChecked)
        {
            { return WebDriver.FindElementByXPath($"//div[@id='input-option223']//input{optionChecked}"); }
        }
        private IWebElement TextProduct
        {
            get { return WebDriver.FindElementById("input-option208"); }
        }
        private IWebElement SelectDropdown
        {
            get { return WebDriver.FindElementByXPath("//select"); }
        }
        private IWebElement SelectNumDropdown (int optionSelected)
        {
            { return WebDriver.FindElementByXPath($"//option[@value][{optionSelected}]"); }
        }
        private IWebElement TextArea
        {
            get { return WebDriver.FindElementById("input-option209"); }
        }
        private IWebElement File
        {
            get { return WebDriver.FindElementById("button-upload222"); }
        }
        private IWebElement DeliveryDate
        {
            get { return WebDriver.FindElementById("input-option219"); }
        }
        private IWebElement HourDelivery
        {
            get { return WebDriver.FindElementById("input-option221"); }
        }
        private IWebElement DateHourDelivery
        {
            get { return WebDriver.FindElementById("input-option220"); }
        }
        private IWebElement Quantity
        {
            get { return WebDriver.FindElementById("input-quantity"); }
        }
        private IWebElement AddToCart
        {
            get { return WebDriver.FindElementById("button-cart"); }
        }
        private ProductPage SetDate()
        {
            //year can be null--> then takes current year
            //format--> yyyy + - + mm + - + dd
            return this;
        }
        private ProductPage SetHour()
        {
            HourDelivery.Click();
            HourDelivery.Clear();
            //hour + : + minutes
            return this;
        }
        private ProductPage SetDateTime()
        {
            //get SetHour and SetDate
            //hour + : + minutes
            return this;
        }
        public ProductPage SelectOptionProduct(int optionSelected)
        {
            SelectDropdown.Click();
            optionSelected =+ 1;
            SelectNumDropdown(optionSelected).Click();
            return this;
        }
        public ProductPage FillQuantity(int quantity)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ProductContainer));
            Quantity.Clear();
            Quantity.Click();
            Quantity.SendKeys(quantity.ToString());
            AddToCart.Click();
            return this;
        }
        public ProductPage FillFullForm(int quantity)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ProductContainer));
            //radio, checkbox, text, select, textarea, file
            SetDate();
            SetHour();
            SetDateTime();
            FillQuantity(quantity);
            return this;
        }
    }
}
