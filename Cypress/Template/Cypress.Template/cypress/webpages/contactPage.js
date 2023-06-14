/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class SearchWebCheckin {
  // Generic elements
  fieldEmail = () => cy.getId("recipient-email");
  fieldName = () => cy.getId("recipient-name");
  fieldMessage = () => cy.getId("message-text");
  // PNR + Email elements
  inputPNR = () => cy.getId("input_emailForm_recordLocator");
  inputEmail = () => cy.getId("input_emailForm_email");
  inputErrorTextPNR = () => cy.get("#emailForm_recordlocator p.validation-info--error");
  inputXErrorPNR = () => cy.get("#emailForm_recordlocator span.vy-icon-error1");

  acceptCookies() {
    this.cookiesButton().click().should("be.visible");
  }

  goContact() {
    this.btnContact().click();
  }
}
