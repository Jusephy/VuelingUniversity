import { HomePage } from "../webpages/HomePage";
import { SelectFlightPage } from "../webpages/SelectFlightPage";
//import { SearchWebCheckin } from "../webpages/searchWebCheckin"; // Webpage Import

// The container of the tests (must contain the same name as the file)
describe("TemplateTest", () => {
  // * let/const for all the tests

  const homePage = new HomePage(); // Object of the webpage
  const selectFlightPage = new SelectFlightPage(); // Object of the webpage
  let dataFlight = {};

  // This will be executed before the execution of every test
  before(() => {
    // Must be included to go to the specified URL
    cy.fixture("dataFlight").then((getDataFlight) => {
      dataFlight = getDataFlight;
    });
  });

  beforeEach(() => {
    cy.visit("");
    homePage.acceptCookies();
  });

  // Independent Test Case
  it("Verify search fligth)", () => {
    // Path added to the base URL
    let index = 0;
    const companySelected = "iberia";
    homePage.selectFlightType(dataFlight[index].flightType);
    homePage.selectADT(dataFlight[index].numADT);
    homePage.selectINF(dataFlight[index].numINF);
    homePage.selectOrigin(dataFlight[index].originCity);
    homePage.selectDestination(dataFlight[index].destinationCity);
    homePage.typeFlightSelected(dataFlight[index].flightType, dataFlight[index].monthDestination);
    homePage.pickDay();
    /*homePage
    .containerSearcherEngine()
      .screenshot(
        `Screenshot_Search_Flight${"_" + dataFlight[index].flightType + "_" + dataFlight[index].originCity + "_" + dataFlight[index].destinationCity}`
        );*/
    homePage.searchFlight();
    selectFlightPage.selectFlight(dataFlight[index].flightCompany);
  });

  xit("Verify search fligth 2)", () => {
    // Path added to the base URL
    let index = 1;
    const primeraVez = 1;
    homePage.selectFlightType(dataFlight[index].flightType);
    homePage.selectADT(dataFlight[index].numADT);
    homePage.selectINF(dataFlight[index].numINF);
    homePage.selectOrigin(dataFlight[index].originCity);
    homePage.selectDestination(dataFlight[index].destinationCity);
    homePage.recursiveClick(dataFlight[index].monthDestination);
    homePage.recursiveClick(dataFlight[index].monthReturn);
    /* homePage.typeFlightSelected(dataFlight[index].flightType, dataFlight[index].monthDestination, dataFlight[index].monthReturn);
    homePage.pickDay();
    homePage.datepickerOW2(primeraVez, dataFlight[index].monthReturn);
    homePage.pickDay(); */
    //homePage.datepickerOW();
    //homePage.datepickerRT(dataFlight[index].monthDestination, dataFlight[index].monthReturn);
    //homePage.datepickerDate(dataFlight[index].monthReturn, dataFlight[index].dayReturn);
    //homePage.datepickerDestination(dataFlight[index].month, dataFlight[index].monthReturn);
    /*homePage
      .containerSearcherEngine()
      .screenshot(
        `Screenshot_Search_Flight${"_" + dataFlight[index].flightType + "_" + dataFlight[index].originCity + "_" + dataFlight[index].destinationCity}`
      );
    homePage.searchFlight();*/
  });

  // This will be executed only once after and for all the tests
  afterEach(() => {
    cy.addContext("Screenshot taken. You can see it in ./cypress/screenshots");
  });
});
