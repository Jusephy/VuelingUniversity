using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.Webpages;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium.Support.UI;
using Demoblaze.Auto.Template.Common;
using System.Diagnostics;
using NUnit.Framework;

namespace Demoblaze.Auto.Template.WebPages
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        /*private IWebElement btnHome
        {
            get { return WebDriver.FindElementByCssSelector("#div[class='card-block']"); }
        }*/
        /*public By User_Name
        {
            //We use By to can use WebDriverWait
            get { return By.CssSelector("nameofuser"); }
        }*/
        private IWebElement BtnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Home ']"); }
        }
        private IWebElement btnContact
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Contact']"); }
        }
        private IWebElement btnAboutUs
{
            get { return WebDriver.FindElementByXPath("//a[text()='About us']"); }
        }
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }
        private IWebElement BtnLogin
        {
            get { return WebDriver.FindElementById("login2"); }
        }
        private IWebElement BtnSingUp
        {
            get { return WebDriver.FindElementById("signin2"); }
        }
        private IWebElement categoryPhones
        {
            //get { return WebDriver.FindElementByXPath("//a[text()='Phones']"); }
            get { return WebDriver.FindElementByXPath("//a[text()='Phones']"); }
        }
        private IWebElement categoryLaptops
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Laptops']"); }
        }
        private IWebElement categoryMonitors
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Monitors']"); }
        }

        public HomePage GoToHome()
        {
            BtnHome.Click();
            return this;
        }
        public HomePage GoToSingUp()
        {
            BtnSingUp.Click();
            return this;
        }
        public HomePage GoToLogin()
        {
            BtnLogin.Click();
            return this;
        }
        public HomePage GoToCart()
        {
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(Nameofuser));
            /*new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = WebDriver.SwitchTo().Alert();
            alert.Accept();*/
            btnCart.Click();
            return this;
        }
        public HomePage GoToCategoryPhones()
        {
            categoryPhones.Click();
            return this;
        }
        public HomePage GoToCategoryLaptops()
        {
            categoryLaptops.Click();
            return this;
        }
        public HomePage GoToCategoryMonitors()
        {
            categoryMonitors.Click();
            return this;
        }
        public HomePage ClickToContact()
        {
            //Jse2.ExecuteScript("arguments[0].scrollIntoView()", btnContact);
            //Thread.Sleep(1000);
            btnContact.Click();
            return this;
        }
        public HomePage GoBack()
        {
            //INavigation.Back("");
            return this;
        }
        //login--> ir a Laptops--> escoger un ordenador-->
        //Add to cart-->Ir a Cart-->Hacer el proceso de compra
        //darle a purchase
    }
}
