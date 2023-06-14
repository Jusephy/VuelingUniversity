/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class ProductPage {
  //Elements
  addToCartBtn = () => cy.get("[onclick='addToCart(2)']");
  productLabel = () => cy.get('h2.name');
  priceLabel = () => cy.get('h3.price-container');
  logInBtn = () => cy.get('[onclick="logIn()"]');

  /*Functions*/
  addProductToCart(categorySelected, index) {
    cy.fixture(categorySelected).then((productList) => {
        this.productLabel().contains(productList[index].name);
      });
    this.addToCartBtn().click();
  }
}
