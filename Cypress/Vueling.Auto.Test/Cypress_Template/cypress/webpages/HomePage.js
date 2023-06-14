/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class HomePage {
  // Elements
  cookiesButton = () => cy.getId("onetrust-accept-btn-handler"); // Search by ID
  alertBanner = () => cy.get("div.alert__message div"); // Search by CSS
  btnLogin = () => cy.get('[data-testid="submit_button"]'); // Search by XPATH

  btnOW = () => cy.get('[for="AvailabilitySearchInputSearchView_OneWay"]');
  btnRT = () => cy.get('[for="AvailabilitySearchInputSearchView_RoundTrip"]');
  inputOrigin = () => cy.get('input#AvailabilitySearchInputSearchView_TextBoxMarketOrigin1');
  inputDestination = () => cy.get('input#AvailabilitySearchInputSearchView_TextBoxMarketDestination1');
  dropdownSearchEngine = () => cy.getId("stationsList");
  citySelected = (cityCode) => cy.get(`[data-id-code='${cityCode}']`);

  dropdownADT = () => cy.getId('adtSelectorDropdown');
  btnADT = (numADT) => cy.get(`#DropDownListPassengerType_ADT_${numADT}`);
  dropdownINF = () => cy.getId('AvailabilitySearchInputSearchView_DropDownListPassengerType_INFANT');

  btnCalendar = () => cy.getId('marketDate1');
  btnNextMonth = () => cy.get('.ui-icon-circle-triangle-e');
  monthLabelRight = () => cy.xpath("//div[@class='ui-datepicker-group ui-datepicker-group-first']//span[@class='ui-datepicker-month']");
  getFirstAvailableDay = () => cy.xpath("(//td[@data-handler='selectDay'])[1]");
  
  btnSearchFlights = () => cy.getId('AvailabilitySearchInputSearchView_btnClickToSearchNormal');

  // Methods
  acceptCookies() {
    this.cookiesButton().click().should("be.visible"); // Action click with an assert
  }

  verificationPage() {
    cy.location("pathname", { timeout: 10000 }).should("eq", "/checkin"); // Assert with timeout
  }

  selectFlightType(typeFlight){
    if(typeFlight=="RT"){
        this.btnRT().should("be.visible").click();
    }else if(typeFlight=="OW"){
        this.btnOW().should("be.visible").click();
    }//make function for multiple destinations
  }

  selectOrigin(originCity){
      this.inputOrigin().click();
      this.dropdownSearchEngine().should("be.visible");
      this.citySelected(originCity).click();
    }
    
    selectDestination(destinationCity){
        this.dropdownSearchEngine().should("be.visible");
        this.citySelected(destinationCity).click();
  }

  selectADT(numADT){
    if(numADT<=3){
        this.dropdownADT().select(numADT, {force:true}).should("be.visible");
    }else if(numADT>3 && numADT<25){
        this.dropdownADT().select(numADT, {force:true}).should("be.visible");
    }
  }

  selectINF(numINF){
    if(numINF<=1){
        this.dropdownINF().select(numINF, {force:true}).should("be.visible");
    }else if(numINF>1 && numINF<=16){
        this.dropdownINF().select(numINF, {force:true}).should("be.visible");
    }
  }

  datepicker(month){
    this.monthLabelRight().then((myText)=>{
        const texto = myText.text();
        if(texto != month){
            this.btnNextMonth().click();
            this.datepicker(month);
        }
    })
    this.getFirstAvailableDay().click({force:true});
  }

  searchFlight(){
    this.btnSearchFlights().click();
  }
}
