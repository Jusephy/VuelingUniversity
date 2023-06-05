using Demoblaze.Auto.Template.WebPages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.Tests
{
    [TestFixture]
    internal class OpenCartTest : TestSetCleanBase
    {
        //[TestCase,Order(1)]
        [TestCase]
        public void RegisterUser()
        {
            oC_HomePage= new OC_HomePage(setUpWebDriver);
            oC_PrivacyErrorPage = new OC_PrivacyErrorPage(setUpWebDriver);
            
            string firstName = "Jusephy";
            string lastName = "Paredes";
            string email = "jusephy.paredes@idk.com";
            int telephone = 622123456;
            string password = "123456";
            bool YorN = false;

            oC_PrivacyErrorPage.GoToPage();
            oC_HomePage.ClickRegister();
            oC_RegisterPage.RegisterUser(firstName, lastName, email, telephone, password, YorN);
        }
        [TestCase]
        public void LoginUser()
        {
            oC_PrivacyErrorPage.GoToPage();
            string email = "jusephy.paredes@idk.com";
            string password ="123456";

            oC_LoginPage.LoginUser(email, password);
        }
        [TestCase]
        public void ContactUs() 
        {
            oC_PrivacyErrorPage.GoToPage();
            string name = "Jusephy";
            string email = "jusephy.paredes@idk.com";
            string enquiry = "Éste mensaje es debido a un ejercicio, siéntete libre de eliminarlo <3";

            oC_ContactPage.ContactForm(name, email, enquiry);
        }
        private string productName = "";
        [TestCase]
        public void AddProductToWishList()
        {
            //string productName = "";

            //precondición--> Estar logeado
            LoginUser();
            oC_HomePage.ClickSoftware();
            oC_CategoryPage.AddProductToWishList(productName);
        }
        [TestCase]
        public void AddProductToCart()
        {

        }
        [TestCase]
        public void GetSponsor()
        {

        }
    }
}
