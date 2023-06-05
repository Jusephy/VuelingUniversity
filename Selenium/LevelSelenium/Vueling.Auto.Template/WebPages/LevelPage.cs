using OpenQA.Selenium;
using Level.Auto.Template.SetUp;
using Level.Auto.Template.WebPages.Base;
using OpenQA.Selenium.Support.UI;
using Level.Auto.Template.Common;
using System;
using System.Threading;

namespace Level.Auto.Template.WebPages
{
    public class LevelPage : CommonPage
    {
        public LevelPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();
        private By CookiesPanel
        {
            get { return By.Id("ensNotifyBanner"); }
        }
        private IWebElement BtnCookies
        {
            get { return WebDriver.FindElementById("ensCloseBanner"); }
        }
        private IWebElement BtnRT
        {
            get { return WebDriver.FindElementByXPath("//div[@class='search-trip-block']//a[@value='RT']"); }
        }
        private IWebElement BtnOW
        {
            get { return WebDriver.FindElementByXPath("//div[@class='search-trip-block']//a[@value='OW']"); }
        }
        private IWebElement BtnRTorOW
        {
            get { return WebDriver.FindElementByXPath("//a[@data-target='dropdown-trip']"); }
        }
        private IWebElement BtnOrigin
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='origin']"); }
        }
        private IWebElement LabelOrigin (string originCityName)
        {// and text()='{originCityName}']
            { return WebDriver.FindElementByXPath($"//div[@data-field='origin']//div[@class='city' and text()='{originCityName}']"); }
            //get { return WebDriver.FindElementByXPath("//div[@data-field='origin']//div[@class='searcher-input-wrapper']"); }
        }
        private IWebElement BtnDestination
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='destination']"); }
        }
        private IWebElement LabelDestination (string destinationCityName)
        {
            { return WebDriver.FindElementByXPath($"//div[@data-field='destination']//div[@class='city' and text()='{destinationCityName}']"); }
        }
        private By ListItemsDestination
        {
            get { return By.XPath("//div[@class='list-items destination js-list-items']"); }
        }
        private IWebElement BtnFlightSwap
        {
            get { return WebDriver.FindElementByXPath("//div[@id='searcher']//span[@role='button']"); }
        }
        private By DatePickerPanel
        {
            get { return By.CssSelector("//div[@class='datepicker-header']"); }
        }
        private IWebElement BtnDayFirstMonthPicker (int departureDayPicked)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='datepicker__months']//section[@class='datepicker__month'][1]//div[@class='datepicker__days']//div[text()='{departureDayPicked}']"); }
        }
        private IWebElement BtnDaySecondMonthPicker (int returnDayPicked)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='datepicker__months']//section[@class='datepicker__month'][2]//div[@class='datepicker__days']//div[text()='{returnDayPicked}']"); }
        }
        /*private IWebElement BtnDatePickerDays (string dayPicked)
        {
            { return WebDriver.FindElementByXPath($"//div[@class='datepicker__days']//div[@class='day' and text()='{dayPicked}']"); }
        }*/
        private IWebElement BtnGetMonth
        {
            get { return WebDriver.FindElementByXPath("//div[@class='datepicker__months']/section[1]//span[@class='month']"); }
        }////section[@class='datepicker__month'][1]//span[@class='month']

        private IWebElement BtnNextMonth
        {
            get { return WebDriver.FindElementByXPath("//button[@class='datepicker__next-action js-month-change']"); }
        }
        private IWebElement BtnDepartureArrivalDate
        {
            get { return WebDriver.FindElementByXPath("//div[@class='departure-date']"); }
        }
        private IWebElement BtnDatePickerListo
        {
            get { return WebDriver.FindElementByXPath("//button[text()='LISTO']"); }
        }
        private IWebElement BtnPassengers
        {
            get { return WebDriver.FindElementByCssSelector("//div[@class='passengers']"); }
        }
        private IWebElement AddADTPassenger
        {
            get { return WebDriver.FindElementByXPath($"//div[@data-field='adult']//div[@class='js-plus']"); }
        }
        private IWebElement MinusADTPassenger
        {
            get { return WebDriver.FindElementByXPath($"//div[@data-field='adult']//span[@class='icon-minus pax-icon']"); }
        }
        private IWebElement AddCHDPassenger
        {
            get { return WebDriver.FindElementByXPath($"//div[@data-field='child']//div[@class='js-plus']"); }
        }
        private IWebElement MinusCHDPassenger
        {
            get { return WebDriver.FindElementByXPath($"//div[@data-field='child']//span[@class='icon-minus pax-icon']"); }
        }
        private IWebElement AddBBYPassenger
        {
            get { return WebDriver.FindElementByXPath($"//div[@data-field='infant']//div[@class='js-plus']"); }
        }
        private IWebElement MinusBBYPassenger
        {
            get { return WebDriver.FindElementByXPath($"//div[@data-field='infant']//span[@class='icon-minus pax-icon']"); }
        }
        private IWebElement BtnSearch
        {
            get { return WebDriver.FindElementById("searcher_submit_buttons"); }
        }
        public LevelPage CloseCookiesDialog()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(CookiesPanel));
            BtnCookies.Click();
            return this;
        }
        public LevelPage SelectRT()
        {
            BtnRTorOW.Click();
            BtnRT.Click();
            return this;
        }
        public LevelPage SelectOW()
        {
            BtnRTorOW.Click();
            BtnOW.Click();
            return this;
        }
        public LevelPage SelectOrigin(string originCityName)
        {
            BtnOrigin.Click();
            BtnOrigin.Click();
            LabelOrigin(originCityName).Click();
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(DatePickerPanel));

            return this;
        }
        public LevelPage SelectDestination(string destinationCityName)
        {
            BtnDestination.Click();
            BtnDestination.Click();
            LabelDestination(destinationCityName).Click();
            return this;
        }public LevelPage SwapDepartureArrival()
        {
            BtnFlightSwap.Click();
            return this;
        }
        public LevelPage SelectMonth(string originMonth)
        {
            while (BtnGetMonth.Text!=originMonth.ToUpper())
            {
                BtnNextMonth.Click();
            }
            return this;
        }
        public LevelPage GetAvailableDay()
        {

            return this;
        }
        public LevelPage DepartureDate(int departureDayPicked)
        {
            //BtnDepartureArrivalDate.Click();
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(DatePickerPanel));
            Thread.Sleep(1000);
            BtnDayFirstMonthPicker(departureDayPicked).Click();
            return this;
        }
        public LevelPage ReturnDate(Nullable <int> returnDayPicked)
        {
            BtnDaySecondMonthPicker((int)returnDayPicked).Click();
            return this;
        }
        public LevelPage AddADT(int numAdtClicks)
        {
            int numClicks = numAdtClicks-1;
            for (int i=0; i<numClicks; i++)
            {
                AddADTPassenger.Click();
            }
            return this;
        }
        public LevelPage AddCHD(int numChdClicks)
        {
            for (int i=0; i< numChdClicks; i++)
            {
                AddCHDPassenger.Click();
            }
            return this;
        }
        public LevelPage AddBBY(int numBbyClicks)
        {
            for (int i=0; i< numBbyClicks; i++)
            {
                AddBBYPassenger.Click();
            }
            return this;
        }
        public LevelPage SelectPassengers()
        {
            BtnDatePickerListo.Click();
            return this;
        }
        public LevelPage MakeSearch(Nullable<int> timetoWait=null)
        {
            Thread.Sleep((int)timetoWait);
            BtnSearch.Click();
            return this;
        }
    }
}
