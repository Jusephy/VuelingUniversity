/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class HomePage {
  // Elements
  cookiesButton = () => cy.getId("onetrust-accept-btn-handler"); // Search by ID
  alertBanner = () => cy.get("div.alert__message div"); // Search by CSS
  btnLogin = () => cy.get('[data-testid="submit_button"]'); // Search by XPATH

  btnOW = () => cy.get('[for="AvailabilitySearchInputSearchView_OneWay"]');
  btnRT = () => cy.get('[for="AvailabilitySearchInputSearchView_RoundTrip"]');
  inputOrigin = () => cy.get("input#AvailabilitySearchInputSearchView_TextBoxMarketOrigin1");
  inputDestination = () => cy.get("input#AvailabilitySearchInputSearchView_TextBoxMarketDestination1");
  dropdownSearchEngine = () => cy.getId("stationsList");
  citySelected = (cityCode) => cy.get(`[data-id-code='${cityCode}']`);

  dropdownADT = () => cy.getId("adtSelectorDropdown");
  btnADT = (numADT) => cy.get(`#DropDownListPassengerType_ADT_${numADT}`);
  dropdownINF = () => cy.getId("AvailabilitySearchInputSearchView_DropDownListPassengerType_INFANT");

  btnCalendar = () => cy.getId("marketDate1");
  btnCalendarReturn = () => cy.getId("marketDate2");
  btnNextMonth = () => cy.get(".ui-icon-circle-triangle-e");
  dateSelected = (monthSelected) => cy.get(`td[data-month='${monthSelected}'] a.ui-state-active`);
  monthLabelLeft = () => cy.get("div.ui-datepicker-group-first span.ui-datepicker-month");
  monthLabelRight = () => cy.get("div.ui-datepicker-group-last span.ui-datepicker-month");
  getAvailableDay = () => cy.get("[data-handler='selectDay']");

  btnSearchFlights = () => cy.getId("AvailabilitySearchInputSearchView_btnClickToSearchNormal");

  containerSearcherEngine = () => cy.get("#buscador");

  // Methods
  acceptCookies() {
    this.cookiesButton().click().should("be.visible"); // Action click with an assert
  }

  verificationPage() {
    cy.location("pathname", { timeout: 10000 }).should("eq", "/checkin"); // Assert with timeout
  }

  selectFlightType(typeFlight) {
    if (typeFlight == "RT") {
      this.btnRT().should("be.visible").click();
    } else if (typeFlight == "OW") {
      this.btnOW().should("be.visible").click();
    } //make function for multiple destinations
  }

  selectOrigin(originCity) {
    this.inputOrigin().click();
    this.dropdownSearchEngine().should("be.visible");
    this.citySelected(originCity).click();
  }

  selectDestination(destinationCity) {
    this.dropdownSearchEngine().should("be.visible");
    this.citySelected(destinationCity).click();
  }

  selectADT(numADT) {
    if (numADT <= 3) {
      //this.dropdownADT().should("be.visible").select();
      this.dropdownADT().select(numADT, { force: true }).should("be.visible");
    } else if (numADT > 3 && numADT < 25) {
      //this.dropdownADT().should("be.visible").select();
      this.dropdownADT().select(numADT, { force: true }).should("be.visible");
    }
  }

  selectINF(numINF) {
    if (numINF <= 1) {
      this.dropdownINF().select(numINF, { force: true }).should("be.visible");
    } else if (numINF > 1 && numINF <= 16) {
      this.dropdownINF().select(numINF, { force: true }).should("be.visible");
    }
  }

  datepickerDate(monthSelected) {
    //monthSelected--;
    cy.clickUntilTextEquals(this.monthLabelLeft, this.btnNextMonth, monthSelected, 10);
    //cy.clickUntilTextNotEqual(this.monthLabelLeft(), this.btnNextMonth(), monthSelected);
    /* this.dateSelected(monthSelected).then((myText) => {
      const day = myText.text();
      if (day == daySelected) {
        myText().click();
      } else if (day != daySelected) {
        this.btnNextMonth().click();
      }
    });*/
  }
  typeFlightSelected(typeFlight, monthDestination, monthReturn) {
    if (typeFlight == "OW") {
      this.datepickerOW(monthDestination);
    } else if (typeFlight == "RT") {
      //this.datepickerOW(monthDestination);
      this.datepickerRT(monthDestination, monthReturn);
    }
  }

  datepickerOW(monthDestination) {
    this.monthLabelLeft().then((myText) => {
      const textoMesIda = myText.text();
      if (textoMesIda != monthDestination) {
        this.btnNextMonth().click();
        cy.log("dentro del OW picker")
        this.datepickerOW(monthDestination);
      }
    });
  }

  recursiveClick(monthDestination){
    return new Promise((resolve)=>{
      this.monthLabelLeft().then((monthText) => {
        const elText = monthText.text();
        if(elText===monthDestination){
          //
          this.getAvailableDay().first().click({ force: true });
          resolve();
        }else{
          this.btnNextMonth().then(($nextMonth)=>{
            if($nextMonth.is(':visible') && $nextMonth.is(':enabled')){
              this.btnNextMonth().click();
              cy.wait(3000);
              this.recursiveClick(monthDestination);
            }else{
              cy.log("Button Next Month NOT FOUND");
              resolve();
            }
          })
        }
      });
    });
  }

  datepickerOW2(primeraVez, monthDestination) {
    //if(primeraVez==1){
      cy.log("dentro del segundo por primera vez")
      //mes con el del anterior
      this.monthLabelLeft()
      this.monthLabelLeft().then((myText) => {
        const texto = myText.text();
        if (texto != monthDestination) {
          //if(this.btnNextMonth().is(':visible') && this.btnNextMonth().is(':enabled')){
            this.btnNextMonth().click();
          //}
          /* Cypress.on("uncaught:exception", (err, runnable) => {
            return false;
          }); */
          cy.wait(1000);
          this.datepickerOW(monthDestination);
        }
      });
    //}
  }
  
  pickDay(){
    this.getAvailableDay().first().click({ force: true });
  }

  datepickerRT(monthDestination, monthReturn) {
    //get month left to select the destination month
    this.monthLabelLeft().then((myText) => {
      const texto = myText.text();
      let isFirstClickDone = false;
      if (texto != monthDestination) {
        this.btnNextMonth().click();
        this.datepickerRT(monthDestination, monthReturn);
        isFirstClickDone=true
      } else if (texto == monthDestination) {
        this.getMonthReturn(monthReturn);
      }
      this.pickDay();
      //if match with month go outside the if, that in this case work
      //like recursive function, now make the same but with monthRight for return
    });
  }
  getMonthReturn(monthReturn) {
    cy.log("Estoy dentro de getMonthReturn")
    this.monthLabelRight().then((myText) => {
      //const texto = myText.text();
      if (!Cypress.dom.isVisible(myText) && myText.text() != monthReturn) {
        this.btnNextMonth().click();
        //repeat the function while the text not match with the month selected
        this.getMonthReturn(monthReturn);
      }
    });
  }

  //options make function that get current text from the month, and compare
  //with the moneth that i send, if != makes click to next months

  /* this.monthLabelLeft(month).then((myMonth) => {
      //const textMonth = myMonth.text();
      if (Cypress.dom.isVisible(myMonth)) {
        //other function that select day
        //this.element(x).should("be.visible");
      } else if (!Cypress.dom.isVisible(myMonth)) {
        this.btnNextMonth().click();
        this.datepickerRT(month, monthReturn);
      }
    }); */
  //get month right to select the return month
  /* this.monthLabelRight(monthReturn).then((myMonth) => {
      //const textMonth = myMonth.text();
      if (Cypress.dom.isVisible(myMonth)) {
        //this.btnNextMonth().click();
        //this.element(x).should("be.visible");
      } else if (!Cypress.dom.isVisible(myMonth)) {
        this.btnNextMonth().click();
        this.datepickerRT(month, monthReturn);
      }
    }); */
  //this.getAvailableDay().first().click({ force: true });

  searchFlight() {
    this.btnSearchFlights().click();
  }
}
