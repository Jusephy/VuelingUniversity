/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class SearchWebCheckin {
  // Generic elements
  btnContact = () => cy.get('//a[text()="Contact"]');

  goContact() {
    this.btnContact().click();
  }
}
