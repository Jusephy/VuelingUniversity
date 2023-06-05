using Level.Auto.Template.WebPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level.Auto.Template.Tests
{
    [TestFixture]
    internal class LevelTest : TestSetCleanBase
    {
        //[TestCase,Order(1)]
        [TestCase]
        public void MakeCompleteFlightTest()
        {
            string originCityName = "Barcelona";
            string destinationCityName = "Buenos Aires";
            string originMonth = "agosto";
            int departureDayPicked = 22;
            int returnDayPicked = 8;
            int numAdtClicks = 3;
            int numChdClicks = 1;
            levelPage = new LevelPage(setUpWebDriver);

            levelPage.CloseCookiesDialog();
            levelPage.SelectOrigin(originCityName);
            levelPage.SelectDestination(destinationCityName);
            levelPage.SelectMonth(originMonth);
            levelPage.DepartureDate(departureDayPicked);
            levelPage.ReturnDate(returnDayPicked);
            levelPage.AddADT(numAdtClicks);
            levelPage.AddCHD(numChdClicks);
            levelPage.SelectPassengers();
            levelPage.MakeSearch();
        }
        [TestCase]
        public void E2E_OW_BCN_JFK_2ADT_1CHD_EcoLight()
        {
            string originCityName = "Barcelona";
            string destinationCityName = "Nueva York";
            string originMonth = "diciembre";
            int departureDayPicked = 23;
            int numAdtClicks=2;
            int numChdClicks=1;
            levelPage = new LevelPage(setUpWebDriver);

            levelPage.CloseCookiesDialog();
            levelPage.SelectOW();
            levelPage.SelectOrigin(originCityName);
            levelPage.SelectDestination(destinationCityName);
            levelPage.SelectMonth(originMonth);
            levelPage.DepartureDate(departureDayPicked);
            levelPage.AddADT(numAdtClicks);
            levelPage.AddCHD(numChdClicks);
            levelPage.SelectPassengers();
            levelPage.MakeSearch(3000);
        }
        [TestCase]
        public void E2E_RT_3ADT_1CHD_1BBY_Sept()
        {
            string originCityName = "Barcelona";
            string destinationCityName = "Santiago de Chile";
            string originMonth= "septiembre";
            int departureDayPicked = 17;
            int returnDayPicked = 28;
            int numAdtClicks = 3;
            int numChdClicks = 1;
            int numBbyClicks = 1;
            levelPage = new LevelPage(setUpWebDriver);

            levelPage.CloseCookiesDialog();
            levelPage.SelectOrigin(originCityName);
            levelPage.SelectDestination(destinationCityName);
            levelPage.SelectMonth(originMonth);
            levelPage.DepartureDate(departureDayPicked);
            levelPage.ReturnDate(returnDayPicked);
            levelPage.AddADT(numAdtClicks);
            levelPage.AddCHD(numChdClicks);
            levelPage.AddBBY(numBbyClicks);
            levelPage.SelectPassengers();
            levelPage.MakeSearch(3000);
        }
    }
}
