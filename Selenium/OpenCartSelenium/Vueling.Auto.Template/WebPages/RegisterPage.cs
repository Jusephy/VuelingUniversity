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
    public class RegisterPage : CommonPage
    {
        public RegisterPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By AccountRegisterLabel
        {
            get { return By.Id("content"); }
        }
        private IWebElement FieldFirstname
        {
            get { return WebDriver.FindElementById("input-firstname"); }
        }
        private IWebElement FieldLastname
        {
            get { return WebDriver.FindElementById("input-lastname"); }
        }
        private IWebElement FieldEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
        private IWebElement FieldTelephone
        {
            get { return WebDriver.FindElementById("input-telephone"); }
        }
        private IWebElement FieldPassword
        {
            get { return WebDriver.FindElementById("input-password"); }
        }
        private IWebElement FieldConfirmPassword
        {
            get { return WebDriver.FindElementById("input-confirm"); }
        }
        private IWebElement RadioSubscribeNewsletter(int newsletterYorN)
        {
            { return WebDriver.FindElementByXPath($"//input[@name='newsletter' and @value='{newsletterYorN}']"); }
        }
        private IWebElement CheckConfirmPrivacy
        {
            get { return WebDriver.FindElementByXPath("//input[@type='checkbox']"); }
        }
        private IWebElement BtnContinue
        {
            get { return WebDriver.FindElementByXPath("//input[@value='Continue']"); }
        }
        /*Elements to check if user was successfully registered*/
        private By SuccesfullRegister
        {
            get { return By.XPath("//div[@id='content']/h1"); }
        }
        private IWebElement BtnContinueToAccountPage
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue']"); }
        }

        int newsletterYorN;
        public RegisterPage RegisterUser(string firstName, string lastName, string email, int telephone, string password, bool YorN)
        {
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(AccountRegisterLabel));
            FieldFirstname.Click();
            FieldFirstname.SendKeys(firstName);
            FieldLastname.Click();
            FieldLastname.SendKeys(lastName);
            FieldEmail.Click();
            FieldEmail.SendKeys(email);
            FieldTelephone.Click();
            FieldTelephone.SendKeys(telephone.ToString());
            FieldPassword.Click();
            FieldPassword.SendKeys(password);
            FieldConfirmPassword.Click();
            FieldConfirmPassword.SendKeys(password);
            if (YorN == true)
            {
                newsletterYorN = 1;
                RadioSubscribeNewsletter(newsletterYorN).Click();
            }
            else
            {
                newsletterYorN = 0;
                RadioSubscribeNewsletter(newsletterYorN).Click();
            }
            CheckConfirmPrivacy.Click();
            BtnContinue.Click();
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(SuccesfullRegister));
            BtnContinueToAccountPage.Click();
            return this;
        }
    }
}
