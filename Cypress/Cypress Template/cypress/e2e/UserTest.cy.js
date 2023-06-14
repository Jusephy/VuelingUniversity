import { HomePage } from "../webpages/HomePage"; // Webpage Import
import { LoginPage } from "../webpages/LoginPage";
import { SignupPage } from "../webpages/SignupPage";

// The container of the tests (must contain the same name as the file)
describe("Verify the flow User", () => {
  // * let/const for all the tests
  let randomUsername = cy.getRandomFirstName();
  let randomPassword = cy.getRandomString(6);
  const username = randomUsername;
  const password = randomPassword;
  const index = 0;

  const homePage = new HomePage(); // Object of the webpage
  const loginPage = new LoginPage();
  const signupPage = new SignupPage();

  // This will be executed before the execution of every test
  beforeEach(() => {
    // Must be included to go to the specified URL
    cy.visit("");
    //With viewport make the page of the test in cypress webpage, with the specified device or (width, height)
    cy.viewport("macbook-15");
  });

  // Independent Test Case
  it("Verify that makes signin succesfully", () => {
    homePage.goSignup();
    signupPage.fillForm(username, password);
  });

  it("Verify that makes login and logout succesfully", () => {
    homePage.goLogin();
    loginPage.fillForm(index, { setTimeout: 10000 });
    homePage.getCurentName(index);
    homePage.goLogout();
  });

  // This will be executed only once after and for all the tests
  after(() => {});
});
