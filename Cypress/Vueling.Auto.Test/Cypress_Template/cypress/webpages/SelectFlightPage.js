/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class SelectFlightPage {
  // Elements
  flightsContainer = () => cy.get('#flightCardsContainer');
  getFlightCompany = (companySelected) => cy.get(`[class^=vy-icon-${companySelected}]`)
  pricesLabel = () => cy.get();

  // Methods
  selectFlight(companySelected) {
    this.flightsContainer().should("be.visible");
    //make counter to get the length of elements that i have
    let counter = 0;
    this.getFlightCompany(companySelected).each(($child)=>{
        counter++;
    }).then(()=>{
        cy.log(counter);
        const random = Math.floor(Math.random()*(counter));
        this.getFlightCompany(companySelected).eq(random).click();
    });
    //this.getFlightCompany(companySelected).first().click();
  }

  select() {
    this.flightsContainer().should("be.visible");
  }
}