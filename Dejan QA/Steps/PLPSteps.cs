using Dejan_QA.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Dejan_QA.Pages;

namespace Dejan_QA.Steps
{
    class PLPSteps :Base
    {

        [Given(@"User opens dresses section")]
        public void GivenUserOpensSection()
        {
            HomePage hp = new HomePage(Driver);
            IList<IWebElement> dresses = Driver.FindElements(hp.dresses);
            dresses[1].Click();
        }
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            PLPPage pd = new PLPPage(Driver);
            Utilities ut = new Utilities(Driver);
            ut.ClickOnElement(pd.firstDress);
        }
        [Given(@"increases quantity to (.*)")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            Utilities ut = new Utilities(Driver);
            Driver.SwitchTo().Frame(Driver.FindElement(By.ClassName("fancybox-iframe")));
            PDPPage pdp = new PDPPage(Driver);
            Driver.FindElement(pdp.quantity).Clear();
            ut.EnterTextInElement(pdp.quantity, qty);
            string productName = ut.ReturnTextFromElement(pdp.productName);
        }

        [When(@"User click on add to cart button")]
         public void WhenUserClickOnAddToCartButton()
         {
            Utilities ut = new Utilities(Driver);
            ShoppingCartPage sp = new ShoppingCartPage(Driver);
            ut.ClickOnElement(sp.addToCart);
            
         }

   }
}
