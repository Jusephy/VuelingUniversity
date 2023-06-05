using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class DesktopPage : CommonPage
    {
        public DesktopPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
