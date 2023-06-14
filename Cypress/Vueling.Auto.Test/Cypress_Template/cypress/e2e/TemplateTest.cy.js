import { HomePage } from "../webpages/HomePage";
//import { SearchWebCheckin } from "../webpages/searchWebCheckin"; // Webpage Import

// The container of the tests (must contain the same name as the file)
describe("TemplateTest", () => {
  // * let/const for all the tests

  const homePage = new HomePage(); // Object of the webpage

  // This will be executed before the execution of every test
  before(() => {
    // Must be included to go to the specified URL
    cy.visit("");
  });

  // Independent Test Case
  it("Verify search fligth)", () => {
    // Path added to the base URL
    const flighType = "OW";
    const numADT = 10;
    const numINF = 1;
    const originCity = "BCN";
    const destinationCity = "ATH";
    const month = "agosto";

    homePage.acceptCookies();
    homePage.selectFlightType(flighType);
    homePage.selectADT(numADT);
    homePage.selectINF(numINF);
    homePage.selectOrigin(originCity);
    homePage.selectDestination(destinationCity);
    homePage.datepicker(month);
    homePage.searchFlight();
  });

  // This will be executed only once after and for all the tests
  after(() => {
    //cy.screenshot(`Screenshot_PNR_${pnr}`);
  });
});
