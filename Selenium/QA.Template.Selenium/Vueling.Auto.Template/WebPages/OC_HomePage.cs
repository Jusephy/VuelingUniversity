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
    public class OC_HomePage : CommonPage
    {
        public OC_HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By C
        {
            get { return By.Id(""); }
        }
        //elements nav top
        private IWebElement DropdownCurrencyExchange
        {
            get { return WebDriver.FindElementByXPath("//strong/../../button"); }
        }
        private IWebElement BtnEuro
        {
            get { return WebDriver.FindElementByXPath("//strong/../..//button[@name='EUR']"); }
        }
        private IWebElement BtnSterlinePound
        {
            get { return WebDriver.FindElementByXPath("//strong/../..//button[@name='GBP']"); }
        }
        private IWebElement BtnDollar
        {
            get { return WebDriver.FindElementByXPath("//strong/../..//button[@name='USD']"); }
        }
        private IWebElement BtnContact
        {
            get { return WebDriver.FindElementByXPath("//i[@class='fa fa-phone']"); }
        }
        private IWebElement DropdownLoginRegister
        {
            get { return WebDriver.FindElementByXPath("//ul[@class='list-inline']/li[@class='dropdown']"); }
        }
        private IWebElement BtnRegister
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Register']"); }
        }
        private IWebElement BtnLogin
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Login']"); }
        }
        private IWebElement BtnWishList
        {
            get { return WebDriver.FindElementById("wishlist-total"); }
        }
        private IWebElement BtnCart
        {
            get { return WebDriver.FindElementByCssSelector("//a[@title='Shopping Cart']"); }
        }
        //elements nav menu
        private IWebElement BtnDesktops
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Desktops']/..//a[@class='see-all']"); }
        }
        private IWebElement BtnLaptopsNotebooks
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Laptops & Notebooks']/..//a[@class='see-all']"); }
        }
        private IWebElement BtnComponents
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Components']/..//a[@class='see-all']"); }
        }
        private IWebElement BtnTablets
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Tablets']"); }
        }
        private IWebElement BtnSoftware
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Software']"); }
        }
        private IWebElement BtnPhonesPDAs
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Phones & PDAs']"); }
        }
        private IWebElement BtnCameras
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='Cameras']"); }
        }
        private IWebElement BtnMP3
        {
            get { return WebDriver.FindElementByCssSelector("//nav[@id='menu']//a[text()='MP3 Players']/..//a[@class='see-all']"); }
        }
        //functions elements nav top
        public OC_HomePage ClickCurrencyExchange(string selectedCurrency)
        {
            DropdownCurrencyExchange.Click();
            if (selectedCurrency=="EUR")
            {
                BtnEuro.Click();
            }else if (selectedCurrency=="GBP")
            {
                BtnSterlinePound.Click();
            }
            else
            {
                BtnDollar.Click();
            }
            return this;
        }
        public OC_HomePage ClickContact()
        {
            BtnContact.Click();
            return this;
        }
        public OC_HomePage ClickRegister()
        {
            DropdownLoginRegister.Click();
            BtnRegister.Click();
            return this;
        }
        public OC_HomePage ClickLogin()
        {
            DropdownLoginRegister.Click();
            BtnLogin.Click();
            return this;
        }
        public OC_HomePage ClickWishList()
        {
            BtnWishList.Click();
            return this;
        }
        public OC_HomePage ClickCart()
        {
            BtnCart.Click();
            return this;
        }
        //functions elements nav menu
        public OC_HomePage ClickDesktops()
        {
            BtnDesktops.Click();
            return this;
        }
        public OC_HomePage ClickLaptopsNotebooks()
        {
            BtnLaptopsNotebooks.Click();
            return this;
        }
        public OC_HomePage ClickComponents()
        {
            BtnComponents.Click();
            return this;
        }
        public OC_HomePage ClickTablets()
        {
            BtnTablets.Click();
            return this;
        }
        public OC_HomePage ClickSoftware()
        {
            BtnSoftware.Click();
            return this;
        }
        public OC_HomePage ClickPhonesPDAs()
        {
            BtnPhonesPDAs.Click();
            return this;
        }
        public OC_HomePage ClickCameras()
        {
            BtnCameras.Click();
            return this;
        }
        public OC_HomePage ClickMP3()
        {
            BtnMP3.Click();
            return this;
        }
    }
}
