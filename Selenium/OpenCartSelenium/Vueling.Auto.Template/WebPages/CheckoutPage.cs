using NUnit.Framework;
using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class CheckoutPage : CommonPage
    {
        public CheckoutPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By ProductContainer
        {
            get { return By.Id("product-product"); }
        }
        private IWebElement ExistAdress
        {
            get { return WebDriver.FindElementByXPath("//input[@name='payment_address' and @value='existing']"); }
        }
        private IWebElement NewAdress
        {
            get { return WebDriver.FindElementByXPath("//input[@name='payment_address' and @value='new']"); }
        }
        private IWebElement FieldFirstname
        {
            get { return WebDriver.FindElementById("input-payment-firstname"); }
        }
        private IWebElement FieldLastname
        {
            get { return WebDriver.FindElementById("input-payment-lastname"); }
        }
        private IWebElement FieldCompany
        {
            get { return WebDriver.FindElementById("input-payment-company"); }
        }
        private IWebElement FieldAdress
        {
            get { return WebDriver.FindElementById("input-payment-address-1"); }
        }
        private IWebElement FieldAdress2
        {
            get { return WebDriver.FindElementById("input-payment-address-2"); }
        }
        private IWebElement FieldCity
        {
            get { return WebDriver.FindElementById("input-payment-city"); }
        }
        private IWebElement FieldPostcode
        {
            get { return WebDriver.FindElementById("input-payment-postcode"); }
        }
        private IWebElement DropdownCountry
        {
            get { return WebDriver.FindElementById("input-payment-country"); }
        }
        private IWebElement Country (string country)
        {
            { return WebDriver.FindElementByXPath($"//option[text()='{country}']"); }
        }
        private IWebElement DropdownRegion
        {
            get { return WebDriver.FindElementById("input-payment-zone"); }
        }
        private IWebElement Region (string city)
        {
            { return WebDriver.FindElementByXPath($"//option[text()='{city}']"); }
        }
        private IWebElement CheckConfirmTerms
        {
            get { return WebDriver.FindElementByXPath("//input[@type='checkbox']"); }
        }
        private By BtnStep2
        {
            get { return By.Id("button-payment-address"); }
        }
        private By BtnStep3
        {
            get { return By.Id("button-shipping-address"); }
        }
        private IWebElement BtnContinueStep3
        {
            get { return WebDriver.FindElementById("button-shipping-address"); }
        }
        private By BtnStep4
        {
            get { return By.Id("button-shipping-method"); }
        }
        private IWebElement BtnContinueStep4
        {
            get { return WebDriver.FindElementById("button-shipping-method"); }
        }
        private By BtnStep5
        {
            get { return By.Id("button-payment-method"); }
        }
        private IWebElement BtnContinueStep5
        {
            get { return WebDriver.FindElementById("button-payment-method"); }
        }
        private By BtnContinueAppear
        {
            get { return By.CssSelector("input[value='Continue']"); }
        }
        private IWebElement BtnContinue
        {
            get { return WebDriver.FindElement(BtnContinueAppear); }
        }
        private IWebElement BtnContinueToHome
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue']"); }
        }
        private By BtnConfirmOrderAppear
        {
            get { return By.CssSelector("input[value='Confirm Order']"); }
        }
        private IWebElement BtnConfirmOrder
        {
            get { return WebDriver.FindElement(BtnConfirmOrderAppear); }
        }
        private IWebElement CheckOrder
        {
            get { return WebDriver.FindElementByXPath("//div[@id='content']/h1[text()='Your order has been placed!']"); }
        }
        public CheckoutPage BilingDetails(Nullable<int> option, string country, string region)
        {
            //Thread.Sleep(2000);
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(BtnStep2));
            if (option==1)
            {
                //click dirección existente
                ExistAdress.Click();
                BtnContinue.Click();
            }
            else if (option==2)
            {
                //si existe dirección pero quieres una nueva
                //click al radio de nueva direccion
                NewAdress.Click();

                FieldFirstname.Click();
                FieldLastname.Click();
                //FieldCompany.Click();
                FieldAdress.Click();
                //FieldAdress2.Click();
                FieldCity.Click();
                //FieldPostcode.Click();
                DropdownCountry.Click();
                Country(country).Click();
                DropdownRegion.Click();
                Region(region).Click();
                BtnContinue.Click();
            }
            else if (option==0)
            {
                //si no existe dirección, rellena los campos
                FieldFirstname.Click();
                FieldLastname.Click();
                //FieldCompany.Click();
                FieldAdress.Click();
                //FieldAdress2.Click();
                FieldCity.Click();
                //FieldPostcode.Click();
                DropdownCountry.Click();
                Country(country).Click();
                DropdownRegion.Click();
                Region(region).Click();
                BtnContinue.Click();
            }
            return this;
        }
        public CheckoutPage DeliveryDetails()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(BtnStep3));
            BtnContinueStep3.Click();
            return this;
        }
        public CheckoutPage DeliveryMethod()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(BtnStep4));
            BtnContinueStep4.Click();
            return this;
        }
        public CheckoutPage PaymentMethod()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(BtnStep5));
            CheckConfirmTerms.Click();
            BtnContinueStep5.Click();
            return this;
        }
        public CheckoutPage ConfirmOrder()
        {
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(BtnContinueAppear));
            BtnConfirmOrder.Click();
            return this;
        }
        public CheckoutPage CheckOrderSuccesfully()
        {
            string orderText = CheckOrder.Text;
            Assert.AreEqual("Your order has been placed!", orderText);
            BtnContinueToHome.Click();
            Console.WriteLine("Compra finalizada, Suuuu");
            return this;
        }
    }
}
