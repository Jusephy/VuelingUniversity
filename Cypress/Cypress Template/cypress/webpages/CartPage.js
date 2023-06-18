/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class CartPage {
  //Elements
  placeOrderBtn = () => cy.get(".btn-success");
  orderModal = () => cy.get('[aria-labelledby="orderModalLabel"]');
  priceLabel = () => cy.get("h3.price-container");
  name = () => cy.get("#name");
  country = () => cy.get("#country");
  city = () => cy.get("#city");
  card = () => cy.get("#card");
  month = () => cy.get("#month");
  year = () => cy.get("#year");
  purchaseBtn = () => cy.get('[onclick="purchaseOrder()"]');
  succesIcon = () => cy.get(".sa-success");
  okBtn = () => cy.get(".confirm");

  /*Functions*/
  checkPrice(categorySelected, index) {
    cy.fixture(categorySelected).then((productList) => {
      this.productLabel().contains(productList[index].name);
    });
  }

  fillPurchaseForm(index) {
    this.placeOrderBtn().click();
    this.orderModal().should("satisfy", Cypress.dom.isVisible);
    cy.fixture("data").then((dataForm) => {
      this.name().type(dataForm[index].name, { delay: 5 }, { force: true });
      this.country().type(dataForm[index].country), { delay: 5 }, { force: true };
      this.city().type(dataForm[index].city, { delay: 5 }, { force: true });
      this.card().type(dataForm[index].card, { delay: 5 }, { force: true });
      this.month().type(dataForm[index].month, { delay: 5 }, { force: true });
      this.year().type(dataForm[index].year, { delay: 5 }, { force: true });
    });
    this.purchaseBtn().click();
  }

  checkOrderComplete() {
    this.succesIcon().should("be.visible", { timeout: 90000 });
    this.okBtn().click();
  }
}
