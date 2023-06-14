/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class LoginPage {
  //Elements
  loginModal = () => cy.get('[aria-labelledby="logInModalLabel"]');
  fieldUsername = () => cy.get("#loginusername");
  fieldPassword = () => cy.get("#loginpassword");
  logInBtn = () => cy.get('[onclick="logIn()"]');

  /*Functions*/
  fillForm(index) {
    this.loginModal().should("satisfy", Cypress.dom.isVisible);
    /*With cy.fixture, we locate to the folder fixtures and inside the brackets we put the name of the json file that 
    we want to handle, with .then() we can interact with the element. And inside the method that we want we call
    the item of the json file to handle it
    */
    cy.fixture("data").then((dataForm) => {
      this.fieldUsername()
        .clear()
        .type(dataForm[index].username, { delay: 5 }, { force: true });
      this.fieldPassword()
        .clear()
        .type(dataForm[index].password, { delay: 5 }, { force: true });
    });
    cy.get(this.logInBtn, { timeout: 10000 }).should("exist");
    this.logInBtn().click();
  }
}
