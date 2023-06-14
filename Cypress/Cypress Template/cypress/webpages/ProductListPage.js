/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class ProductListPage {
  //Elements
  product = () => cy.get(".hrefch");
  fieldUsername = () => cy.get("#loginusername");
  fieldPassword = () => cy.get("#loginpassword");
  logInBtn = () => cy.get('[onclick="logIn()"]');

  /*Functions*/
  selectProduct(categorySelected, index) {
    cy.fixture(categorySelected).then((productList) => {
      this.product().contains(productList[index].name).click();
    });
  }
}
