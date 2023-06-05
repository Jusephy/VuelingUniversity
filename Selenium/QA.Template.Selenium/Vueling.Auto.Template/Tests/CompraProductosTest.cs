using AventStack.ExtentReports;
using Demoblaze.Auto.Template.WebPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.Tests
{
    [TestFixture]
    internal class CompraProductosTest : TestSetCleanBase
    {
        //[TestCase,Order(1)]
        [TestCase]
        public void LoginTest()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage= new LoginPage(setUpWebDriver);
            laptopsPage= new LaptopsPage(setUpWebDriver);

            homePage.GoToLogin();
            loginPage.Login();
            test.Log(Status.Debug, "Hace Login con usuario");

        }
        [TestCase]
        public void SelectLaptopAddToCartAndPurchase()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage= new LoginPage(setUpWebDriver);
            laptopsPage= new LaptopsPage(setUpWebDriver);
            productPage= new ProductPage(setUpWebDriver);
            cartPage= new CartPage(setUpWebDriver);

            homePage.GoToCategoryLaptops();
            test.Log(Status.Debug, "Va a la Categoría Laptops");
            laptopsPage.GoToSelectedLaptop("MacBook air");
            test.Log(Status.Debug, "Selecciona la laptop");
            productPage.AddProductToCart();
            test.Log(Status.Debug,"Añade la laptop al carrito");
            homePage.GoToHome();
            test.Log(Status.Debug,"Va a Home");
            homePage.GoToCategoryLaptops();
            test.Log(Status.Debug,"Va a la Categoría Laptops");
            laptopsPage.GoToSecondPage();
            test.Log(Status.Debug,"Va a la página siguiente de Laptops");
            laptopsPage.GoToSecondSelectedLaptop("MacBook Pro");
            test.Log(Status.Debug, "Selecciona la laptop");
            productPage.AddProductToCart();
            test.Log(Status.Debug,"Añade la laptop al carrito");
            homePage.GoToCart();
            test.Log(Status.Debug, "Va al carrito");
            cartPage.FillInputsPurchase();
            test.Log(Status.Debug, "Hace la compra de los productos");
            cartPage.CheckMakePurchase();
            test.Log(Status.Debug, "Check si se hizo la compra");
        }
        [TestCase]
        public void SelectPhoneAddToCartAndPurchase()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            phonesPage = new PhonesPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Va a la Categoría Phones");
            phonesPage.GoToSelectedPhone("Samsung galaxy s6");
            test.Log(Status.Debug, "Selecciona el móvil");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade el móvil al carrito");
            homePage.GoToHome();
            test.Log(Status.Debug, "Va a Home");
            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Va a la Categoría Phones");
            phonesPage.GoToSecondSelectedPhone("Sony xperia z5");
            test.Log(Status.Debug, "Selecciona el móvil");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade el móvil al carrito");
            homePage.GoToCart();
            test.Log(Status.Debug, "Va al carrito");
            cartPage.FillInputsPurchase();
            test.Log(Status.Debug, "Hace la compra de los productos");
            cartPage.CheckMakePurchase();
            test.Log(Status.Debug, "Check si se hizo la compra");
        }
        [TestCase]
        public void SelectMonitorAddToCartAndPurchase()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            monitorsPage = new MonitorsPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.GoToCategoryMonitors();
            test.Log(Status.Debug, "Va a la Categoría Monitors");
            monitorsPage.GoToSelectedMonitor();
            test.Log(Status.Debug, "Selecciona el monitor");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade el monitor al carrito");
            homePage.GoToHome();
            test.Log(Status.Debug, "Va a Home");
            homePage.GoToCategoryMonitors();
            test.Log(Status.Debug, "Va a la Categoría Monitors");
            monitorsPage.GoToSecondSelectedMonitor();
            test.Log(Status.Debug, "Selecciona el monitor");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade el monitor al carrito");
            homePage.GoToCart();
            test.Log(Status.Debug, "Va al carrito");
            cartPage.FillInputsPurchase();
            test.Log(Status.Debug, "Hace la compra de los productos");
            cartPage.CheckMakePurchase();
            test.Log(Status.Debug, "Check si se hizo la compra");
        }
        [TestCase]
        public void SelectProductsAddToCartCheckCart()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            phonesPage = new PhonesPage(setUpWebDriver);
            laptopsPage = new LaptopsPage(setUpWebDriver);
            monitorsPage = new MonitorsPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Va a la Categoría Phones");
            phonesPage.GoToSecondSelectedPhone("Sony xperia z5");
            test.Log(Status.Debug, "Selecciona el móvil");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade el móvil al carrito");
            homePage.GoToHome();
            test.Log(Status.Debug, "Va a Home");
            homePage.GoToCategoryLaptops();
            test.Log(Status.Debug, "Va a la Categoría Laptops");
            laptopsPage.GoToSelectedLaptop("MacBook air");
            test.Log(Status.Debug, "Selecciona la laptop");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade la laptop al carrito");
            homePage.GoToCart();
            test.Log(Status.Debug, "Va al carrito");
            cartPage.CheckIfProductExistInCart("Sony xperia z5");
            test.Log(Status.Debug, "Verifica que existan los productos");
        }
        [TestCase]
        public void DeleteProductOfCart()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            phonesPage = new PhonesPage(setUpWebDriver);
            laptopsPage = new LaptopsPage(setUpWebDriver);
            monitorsPage = new MonitorsPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Va a la Categoría Phones");
            phonesPage.GoToThirdSelectedPhone("Nokia lumia 1520");
            test.Log(Status.Debug, "Selecciona el móvil");
            productPage.AddProductToCart();
            test.Log(Status.Debug, "Añade el móvil al carrito");
            homePage.GoToCart();
            test.Log(Status.Debug, "Va al carrito");
            cartPage.DeleteProduct("Nokia lumia 1520");
            test.Log(Status.Debug, "Elimina el producto");
        }
        /*[TestCase]
        public void ContactTest()
        {
            test.Log(Status.Debug, "Entra en Demoblaze.");
            homePage.GoToCategoryPhones();
            test.Log(Status.Debug, "Clica en Categories-> Phones.");
            homePage.ClickToContact();
            test.Log(Status.Debug, "Clica en Contact");
            contactPage.FillContact();
            test.Log(Status.Debug, "Rellenar Contact Message");
            test.Log(Status.Debug, "Enviar Message");
            test.Log(Status.Pass, "Fin del test.");
        }*/
    }
}
