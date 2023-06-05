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
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
        private IWebElement DropdownLoginRegisterOpened
        {
            get { return WebDriver.FindElementByXPath("//ul[@class='list-inline']/li[@class='dropdown open']"); }
        }
        private IWebElement DropdownOpenedLoginRegister
        {
            get { return WebDriver.FindElementByXPath("//ul[@class='list-inline']/li[@class='dropdown open']"); }
        }
        /*If user is not logged in*/
        private IWebElement BtnRegister
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Register']"); }
        }
        private IWebElement BtnLogin
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Login']"); }
        }
        /*If user is logged appear*/
        private By MyAccount
        {
            get { return By.XPath("//a[text()='My Account']"); }
        }
        private IWebElement BtnMyAccount
        {
            get { return (IWebElement)DropdownOpenedLoginRegister.FindElements(MyAccount); }
        }
        private IWebElement BtnOrderHistory
        {
            get { return (IWebElement)DropdownOpenedLoginRegister.FindElements(By.XPath("//a[text()='Order History']")); }
        }
        private IWebElement BtnTransactions
        {
            get { return (IWebElement)DropdownOpenedLoginRegister.FindElements(By.XPath("//a[text()='Transactions']")); }
        }
        private IWebElement BtnDownloads
        {
            get { return (IWebElement)DropdownOpenedLoginRegister.FindElements(By.XPath("//a[text()='Downloads']")); }
        }
        private By Logout
        {
            get { return By.XPath("//div[@class='list-group']//a[text()='Logout']"); }
        }
        private IWebElement BtnLogout
        {
            get { return (IWebElement)DropdownLoginRegister.FindElements(Logout); }
        }
        /*-----*/
        private IWebElement BtnWishList
        {
            get { return WebDriver.FindElementById("wishlist-total"); }
        }
        private IWebElement BtnCart
        {
            get { return WebDriver.FindElementByCssSelector("a[title='Shopping Cart']"); }
        }
        //elements nav menu
        private IWebElement BtnDesktops
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Desktops']/..//a[@class='see-all']"); }
        }
        private IWebElement DropdownLaptopsNotebooks
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Laptops & Notebooks']/../a/.."); }
        }
        private IWebElement BtnLaptopsNotebooks
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Laptops & Notebooks']/..//a[@class='see-all']"); }
        }
        private IWebElement BtnComponents
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Components']/..//a[@class='see-all']"); }
        }
        private IWebElement BtnTablets
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Tablets']"); }
        }
        private IWebElement BtnSoftware
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Software']"); }
        }
        private IWebElement BtnPhonesPDAs
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Phones & PDAs']"); }
        }
        private IWebElement BtnCameras
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='Cameras']"); }
        }
        private IWebElement DropdownMP3
        {
            get { return WebDriver.FindElementByXPath("//a[text()='MP3 Players']/../a"); }
        }
        private IWebElement BtnMP3
        {
            get { return WebDriver.FindElementByXPath("//nav[@id='menu']//a[text()='MP3 Players']/..//a[@class='see-all']"); }
        }
        //footer elements
        private IWebElement GetSponsor (string sponsor)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='swiper-slide text-center']//img[@alt='{sponsor}']"); }
        }
        //product
        private By ProductSelected (string productName)
        {
            { return By.XPath($"//a[text()='{productName}']"); }
        }
        //functions elements nav top
        public HomePage ClickCurrencyExchange(string selectedCurrency)
        {
            DropdownCurrencyExchange.Click();
            if (selectedCurrency=="EUR")
            {
                BtnEuro.Click();
            }else if (selectedCurrency=="GBP")
            {
                BtnSterlinePound.Click();
            }
            else if(selectedCurrency=="USD")
            {
                BtnDollar.Click();
            }
            else
            {
                Assert.Fail("The currency selected is out the parameters");
            }
            return this;
        }
        public HomePage ClickContact()
        {
            BtnContact.Click();
            return this;
        }
        public HomePage ClickRegister()
        {
            DropdownLoginRegister.Click();
            BtnRegister.Click();
            return this;
        }
        public HomePage ClickLogin()
        {
            DropdownLoginRegister.Click();
            BtnLogin.Click();
            return this;
        }
        public HomePage ClickWishList()
        {
            BtnWishList.Click();
            return this;
        }
        public HomePage ClickCart()
        {
            BtnCart.Click();
            return this;
        }
        //functions elements nav menu
        public HomePage ClickDesktops()
        {
            BtnDesktops.Click();
            return this;
        }
        public HomePage ClickLaptopsNotebooks()
        {
            DropdownLaptopsNotebooks.Click();
            BtnLaptopsNotebooks.Click();
            return this;
        }
        public HomePage ClickComponents()
        {
            BtnComponents.Click();
            return this;
        }
        public HomePage ClickTablets()
        {
            BtnTablets.Click();
            return this;
        }
        public HomePage ClickSoftware()
        {
            BtnSoftware.Click();
            return this;
        }
        public HomePage ClickPhonesPDAs()
        {
            BtnPhonesPDAs.Click();
            return this;
        }
        public HomePage ClickCameras()
        {
            BtnCameras.Click();
            return this;
        }
        public HomePage ClickMP3()
        {
            DropdownMP3.Click();
            BtnMP3.Click();
            return this;
        }
        public HomePage CheckUserRegisteredLoginSuccesfull()
        {
            DropdownLoginRegister.Click(); new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(Logout));
            DropdownLoginRegisterOpened.Click();
            return this;
        }
        public HomePage CheckProductAddedWishList(string productName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(ProductSelected(productName)));
            return this;
        }
        public HomePage CheckExistsSponsor(string sponsor)
        {
            string sponsorName = GetSponsor(sponsor).GetAttribute("alt");
            Assert.AreEqual(sponsor,sponsorName);
            return this;
        }
    }
}
