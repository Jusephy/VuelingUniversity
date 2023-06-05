using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class OC_PrivacyErrorPage : CommonPage
    {
        public OC_PrivacyErrorPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
        public OC_PrivacyErrorPage GoToPage()
        {
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(IconAlertMessage));
            AdvancedConfig.Click();
            LinkAccesWebPage.Click();
            return this;
        }
    }
}
