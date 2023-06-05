using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class PrivacyErrorPage : CommonPage
    {
        public PrivacyErrorPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By IconAlertMessage
        {
            get { return By.Id("icon"); }
        }
        private IWebElement AdvancedConfig
        {
            get { return WebDriver.FindElementById("details-button"); }
        }
        private IWebElement LinkAccesWebPage
        {
            get { return WebDriver.FindElementById("proceed-link"); }
        }
        public PrivacyErrorPage GoToPage()
        {
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(IconAlertMessage));
            AdvancedConfig.Click();
            LinkAccesWebPage.Click();
            return this;
        }
    }
}
