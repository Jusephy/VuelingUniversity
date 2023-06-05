using Demoblaze.Auto.Template.Common;
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
    public class OC_ProductPage : CommonPage
    {
        public OC_ProductPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
            get { return WebDriver.FindElementByCssSelector("//select"); }
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
        private OC_ProductPage SetDate()
        {
            //year can be null--> then takes current year
            //format--> yyyy + - + mm + - + dd
            return this;
        }
        private OC_ProductPage SetHour()
        {
            HourDelivery.Click();
            HourDelivery.Clear();
            //hour + : + minutes
            return this;
        }
        private OC_ProductPage SetDateTime()
        {
            //get SetHour and SetDate
            //hour + : + minutes
            return this;
        }
        public OC_ProductPage FillQuantity()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ProductContainer));
            AddToCart.Click();
            return this;
        }
        public OC_ProductPage FillFullForm()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ProductContainer));
            //radio, checkbox, text, select, textarea, file
            SetDate();
            SetHour();
            SetDateTime();
            FillQuantity();
            return this;
        }
    }
}
