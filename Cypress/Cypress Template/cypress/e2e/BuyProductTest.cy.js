import { HomePage } from "../webpages/HomePage";
import { ProductListPage } from "../webpages/ProductListPage";
import { ProductPage } from "../webpages/ProductPage";
import { CartPage } from "../webpages/CartPage";

// The container of the tests (must contain the same name as the file)
describe("TemplateTest", () => {
  // * let/const for all the tests

  //the categories can be 'phone', 'notebook', 'monitor'
  const categorySelected = "phone";
  const index = 1;

  const homePage = new HomePage(); // Object of the webpage
  const productListPage = new ProductListPage();
  const productPage = new ProductPage();
  const cartPage = new CartPage();

  // This will be executed before the execution of every test
  beforeEach(() => {
    // Must be included to go to the specified URL
    cy.visit("");
    cy.viewport("macbook-15");
  });

  // Independent Test Case
  it("Buy one product", () => {
    homePage.goCategory(categorySelected);
    productListPage.selectProduct(categorySelected, index);
    productPage.addProductToCart(categorySelected, index);
    homePage.goCart();
    //cartPage.checkPrice()
    cartPage.fillPurchaseForm(index);
    cartPage.checkOrderComplete();
  });

  // This will be executed after the execution of every test
  afterEach(() => {
    // This will save a screenshot into the screenshots folder
    //cy.screenshot(`Screenshot_PNR_${pnr}`);
  });
});
