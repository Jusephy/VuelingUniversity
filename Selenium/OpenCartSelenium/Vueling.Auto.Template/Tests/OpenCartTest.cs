using OpenCart.Auto.Template.WebPages.Base;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OpenCart.Auto.Template.Tests
{
    [TestFixture]
    internal class OpenCartTest : TestSetCleanBase
    {
        //[TestCase,Order(1)]
        [TestCase]
        public void RegisterUser()
        {
            homePage= new HomePage(setUpWebDriver);
            privacyErrorPage = new PrivacyErrorPage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);
            
            string firstName = "Jusephy";
            string lastName = "Paredes";
            string email = "jusephy.paredes@idk.com";
            int telephone = 622123456;
            string password = "123456";
            bool YorN = true;

            privacyErrorPage.GoToPage();
            homePage.ClickRegister();
            registerPage.RegisterUser(firstName, lastName, email, telephone, password, YorN);
            homePage.CheckUserRegisteredLoginSuccesfull();
            //assert here? or in the function of the page?
        }
        [TestCase]
        public void LoginUser()
        {
            homePage= new HomePage(setUpWebDriver);
            privacyErrorPage = new PrivacyErrorPage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            
            string email = "jusephy.paredes@idk.com";
            string password ="123456";
            
            privacyErrorPage.GoToPage();
            homePage.ClickLogin();
            loginPage.LoginUser(email, password);
            homePage.CheckUserRegisteredLoginSuccesfull();
        }
        [TestCase]
        public void ContactUs() 
        {
            homePage = new HomePage(setUpWebDriver);
            contactPage = new ContactPage(setUpWebDriver);

            string name = "Jusephy";
            string email = "jusephy.paredes@idk.com";
            string enquiry = "Éste mensaje es debido a un ejercicio, siéntete libre de eliminarlo <3";

            LoginUser();
            homePage.ClickContact();
            contactPage.ContactForm(name, email, enquiry);
            contactPage.ContactSuccesfully();
        }
        [TestCase]
        public void AddProductToWishList()
        {
            homePage = new HomePage(setUpWebDriver);
            categoryPage = new CategoryPage(setUpWebDriver);
            
            string productName = "iPhone";

            //precondición--> Estar logeado
            LoginUser();
            homePage.ClickSoftware();
            categoryPage.AddProductToWishList(productName);
        }
        [TestCase]
        public void AddProductToCart()
        {
            homePage = new HomePage(setUpWebDriver);
            categoryPage = new CategoryPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);
            checkoutPage = new CheckoutPage(setUpWebDriver);

            string productName = "Nikon D300";
            string productName2 = "MacBook Pro";
            int optionSelected = 1;
            int quantity = 1;
            int option=1;
            string country="Spain";
            string region="Barcelona";

            LoginUser();
            //homePage.ClickDesktops();
            //homePage.ClickComponents();
            //homePage.ClickTablets();
            //homePage.ClickPhonesPDAs();
            //homePage.ClickMP3();
            homePage.ClickCameras();
            categoryPage.AddProductToCart(productName);
            homePage.ClickLaptopsNotebooks();
            categoryPage.AddProductToCart(productName2);
            //categoryPage.AddPhoneToCart(productName);
            //productPage.SelectOptionProduct(optionSelected);
            //productPage.FillQuantity(quantity);
            homePage.ClickCart();
            cartPage.MakeCheckout();
            checkoutPage.BilingDetails(option, country, region);
            checkoutPage.DeliveryDetails();
            checkoutPage.DeliveryMethod();
            checkoutPage.PaymentMethod();
            checkoutPage.ConfirmOrder();
            checkoutPage.CheckOrderSuccesfully();
        }
        [TestCase]
        public void ClickProductAddToCart()
        {
            homePage = new HomePage(setUpWebDriver);
            categoryPage = new CategoryPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);
            checkoutPage = new CheckoutPage(setUpWebDriver);

            string productName = "iPhone";
            int quantity = 1;
            int option=1;
            string country="Spain";
            string region="Barcelona";

            LoginUser();
            homePage.ClickPhonesPDAs();
            categoryPage.ClickPhone(productName); ;
            productPage.FillQuantity(quantity);
            homePage.ClickCart();
            cartPage.MakeCheckout();
            checkoutPage.BilingDetails(option, country, region);
            checkoutPage.DeliveryDetails();
            checkoutPage.DeliveryMethod();
            checkoutPage.PaymentMethod();
            checkoutPage.ConfirmOrder();
            checkoutPage.CheckOrderSuccesfully();
        }
        [TestCase]
        public void GetSponsor()
        {
            privacyErrorPage = new PrivacyErrorPage(setUpWebDriver);
            homePage = new HomePage(setUpWebDriver);

            string sponsor = "Nintendo";

            privacyErrorPage.GoToPage();
            homePage.CheckExistsSponsor(sponsor);
        }
    }
}
