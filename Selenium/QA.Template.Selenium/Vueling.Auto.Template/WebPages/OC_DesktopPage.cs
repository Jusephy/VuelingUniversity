using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class OC_DesktopPage : CommonPage
    {
        public OC_DesktopPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By C
        {
            get { return By.Id(""); }
        }
        private IWebElement BtnContact
        {
            get { return WebDriver.FindElementByXPath("//i[@class='fa fa-phone']"); }
        }
    }
}
