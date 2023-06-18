/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class HomePage {
  //Elements --> before work with elements we should have knowledge about Css Selector and XPath
  signUpBtn = () => cy.get("#signin2");
  logInBtn = () => cy.get("#login2");
  logOutBtn = () => cy.get("#logout2");
  welcomeUser = () => cy.get("#nameofuser");
  cartBtn = () => cy.get("#cartur");
  category = (categorySelected) => cy.get(`[onclick="byCat('${categorySelected}')"]`);

  /*Functions*/
  //Makes click and assert if its visible
  goSignup() {
    this.signUpBtn().click().should("be.visible");
  }

  goLogin() {
    this.logInBtn().click().should("be.visible");
  }

  goLogout() {
    this.logOutBtn().click().should("be.visible");
  }

  goCart() {
    this.cartBtn().click().should("be.visible");
  }

  //Function with parameters
  getCurentName(index) {
    cy.fixture("data").then((dataForm) => {
      this.welcomeUser().contains(dataForm[index].username);
    });
  }

  goCategory(categorySelected) {
    this.category(categorySelected).click();
  }
}
