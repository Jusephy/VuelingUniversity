/// <reference types='cypress-xpath' />

import "cypress-xpath/src/index";

export class SignupPage {
  //Elements
  signinModal = () => cy.get('[aria-labelledby="signInModalLabel"]');
  fieldUsername = () => cy.get("#sign-username");
  fieldPassword = () => cy.get("#sign-password");
  signUpBtn = () => cy.get('[onclick="register()"]');

  /*Functions*/
  fillForm(username, password) {
    //With the Cypress.dom.isVisible we check if the element exists in the DOM
    this.signinModal().should("satisfy", Cypress.dom.isVisible);
    //In this element we clean it in case is previous text and then we type the parameter
    //With delay we set time to wait for cypress to write
    this.fieldUsername().clear().type(username, { delay: 0 }, { force: true });
    this.fieldPassword().clear().type(password, { delay: 0 });
    this.signUpBtn().click(); //.click() obviously make a click "This only work with Buttons and Links!"
    
    /*if we want to make this with a select, this should be the sintaxis:
    
    this.dropdown().select(num);
    
    in dropdown we select with Css Selector or XPath the parent item that have the tag <select/>
    then for click it we type .select(), and inside the brackets we send the parameter that contains the <option/>
    */
  }

  checkSignUp(){
    //We use cy.on to listen events
    cy.on('window:alert', (str)=>{
        //Verify that the alert message is the expected
        expect(str).to.equal("Sign up successful.")
    })
  }
}
