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

    }
}
