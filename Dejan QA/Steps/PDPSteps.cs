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
    class PDPSteps
    {
        public IWebDriver Driver { get; private set; }

        [Given(@"User opens 'dresses' section")]
        public void GivenUserOpensSection(string p0)
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.signIn);
        }


    }
}
