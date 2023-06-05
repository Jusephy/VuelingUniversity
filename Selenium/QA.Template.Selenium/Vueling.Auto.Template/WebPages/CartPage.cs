using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Demoblaze.Auto.Template.WebPages
{
    public class CartPage : CommonPage
    {
        PhonesPage phonesPage;
        CustomExpectedConditions customexpcond = new CustomExpectedConditions();
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        public CartPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        private IWebElement Name
        {
            get { return WebDriver.FindElement(By.Id("name")); }
        }
        private IWebElement Country
        {
            get { return WebDriver.FindElementById("country"); }
        }
        private IWebElement City
        {
            get { return WebDriver.FindElementById("city"); }
        }
        private IWebElement CreditCard
        {
            get { return WebDriver.FindElementById("card"); }
        }
        private IWebElement Month
        {
            get { return WebDriver.FindElementById("month"); }
        }
        private IWebElement Year
        {
            get { return WebDriver.FindElementById("year"); }
        }
        private IWebElement BtnPlaceOrder
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Place Order']"); }
        }
        private IWebElement BtnPurchase
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Purchase']"); }
        }
        /*private By SuccesfullPurchaseLogo
        {
            get { return By.CssSelector("sa-placeholder"); }
        }*/
        private IWebElement Product1
        {
            get { return WebDriver.FindElementByXPath("//td[text()='Samsung galaxy s6']"); }
        }
        private IWebElement Product2
        {
            get { return WebDriver.FindElementByXPath("//td[text()='MacBook air']"); }
        }
        private By SuccesfullPurchase_Logo
        {
            get { return By.ClassName("sa-placeholder"); }
        }
        private IWebElement SuccesfullPurchaseLogo
        {
            get { return WebDriver.FindElement(SuccesfullPurchase_Logo); }
        }
        private By PlaceOrderPurchaseLabel
        {
            get { return By.Id("orderModalLabel"); }
        }
        private IWebElement BtnOK
        {
            get { return WebDriver.FindElementByXPath("//button[text()='OK']"); }
        }
        private IWebElement BtnClose
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Close']"); }
        }
        private IWebElement BtnDelete (string itemName)
        {
            { return WebDriver.FindElementByXPath($"//tr[@class='success']/td[text()='{itemName}']/../td/a"); }
        }
        public CartPage FillInputsPurchase()
        {
            BtnPlaceOrder.Click();
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(PlaceOrderPurchaseLabel));
            Name.SendKeys("Jusephy");
            Country.SendKeys("España");
            City.SendKeys("Hospitalet de Llobregat");
            CreditCard.SendKeys("1234567890");
            Month.SendKeys("10");
            Year.SendKeys("2029");
            BtnPurchase.Click();
            return this;
        }
        public CartPage CheckIfProductExistInCart(string phoneItemName)
        {
            bool IsVisibleProduct1 = IsElementDisplayed(Product1);
            bool IsVisibleProduct2 = IsElementDisplayed(Product2);
            if (IsVisibleProduct1 == true && IsVisibleProduct2 == true)
            {
                Assert.AreEqual(Product1.Text,"Samsung galaxy s6");
                Console.WriteLine("El elemento se muestra");
                //BtnOK.Click();
            }
            else
            {
                Console.WriteLine("El elemento no de muestra en la pantalla");
            }
            return this;
        }
        public CartPage CheckMakePurchase()
        {
            //IWebElement SuccesfulLogo = WebDriver.FindElementById("sa-placeholder");
            bool IsVisible = IsElementDisplayed(SuccesfullPurchaseLogo);
            //bool IsVisible = IsElementDisplayed(SuccesfulLogo);
            if (IsVisible==true)
            {
                Thread.Sleep(1000);
                new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(SuccesfullPurchase_Logo));
                Console.WriteLine("El elemento se muestra");
                BtnOK.Click();
                //WebDriver.Quit();
                //BtnClose.Click();
            }
            else
            {
                Console.WriteLine("El elemento no de muestra en la pantalla");
            }

            return this;
        }
        public CartPage DeleteProduct(string itemName)
        {
            BtnDelete(itemName).Click();
            //check if the delete was good
            return this;
        }
    }
}
