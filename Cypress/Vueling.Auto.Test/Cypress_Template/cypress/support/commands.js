// ***********************************************
// This example commands.js shows you how to
// create various custom commands and overwrite
// existing commands.
//
// For more comprehensive examples of custom
// commands please read more here:
// https://on.cypress.io/custom-commands
// ***********************************************
//
//
// -- This is a parent command --
// Cypress.Commands.add("login", (email, password) => { ... })
//
//
// -- This is a child command --
// Cypress.Commands.add("drag", { prevSubject: 'element'}, (subject, options) => { ... })
//
//
// -- This is a dual command --
// Cypress.Commands.add("dismiss", { prevSubject: 'optional'}, (subject, options) => { ... })
//
//
// -- This will overwrite an existing command --
// Cypress.Commands.overwrite("visit", (originalFn, url, options) => { ... })../../screenshots/

import addContext from "mochawesome/addContext";

// Cypress.Commands.add("addContext", (context, imgValue= 'noImgAttached') => {
//   const screenshotsFolder = "../screenshots/";
//   cy.once("test:after:run", (test) => addContext({ test }, context, `${screenshotsFolder}${{test}}/${imgValue}`))
// });
Cypress.Commands.add("addContext", (context) => {
  cy.once("test:after:run", (test) => addContext({ test }, context));
});
Cypress.Commands.add("getId", (id) => {
  // Command 'cy.getId' for search by Id
  cy.get(`#${id}`);
});

/* Cypress.Commands.add('clickUntilTextNotEqual', (elementSelector, textToMatch) => {
  cy.get(elementSelector).should('contain', textToMatch).click().then(() => {
    cy.get(elementSelector).should('not.contain', textToMatch).then(($element) => {
      if ($element.text() !== textToMatch) {
        cy.clickUntilTextNotEqual(elementSelector, textToMatch);
      }
    });
  });
}); 

Cypress.Commands.add('clickUntilTextNotEqual', (elementSelector, targetSelector, textToMatch) => {
  const checkTextAndClick = ($element) => {
    if ($element.text() != textToMatch) {
      cy.get(targetSelector).click().then(() => {
        cy.get(elementSelector).should('not.have.text', textToMatch).then(checkTextAndClick);
      });
    }
    cy.get(elementSelector).should('contain', textToMatch).then(checkTextAndClick);
  };
});*/

Cypress.Commands.add('clickUntilTextEquals', (elementSelector, targetSelector, textToMatch, maxAttempts = 10) => {
  let attempts = 0;

  const checkTextAndClick = () => {
    attempts++;

    if (attempts > maxAttempts) {
      throw new Error(`Exceeded maximum attempts (${maxAttempts})`);
    }

    cy.get(elementSelector).should('have.text', textToMatch).then(() => {
      cy.get(targetSelector).click().then(checkTextAndClick);
    });
  };
  /*if(elementSelector.text!=textToMatch){
    checkTextAndClick();
  }*/

  cy.get(elementSelector).should('not.have.text', textToMatch).then(checkTextAndClick);
});

Cypress.Commands.add("error", (text) => {
  throw new Error(text);
});

Cypress.Commands.add("addScreshotContext", (text) => {
  cy.screenshot();
  cy.addTestContext(text);
});

//! Create after more commands for cypress
