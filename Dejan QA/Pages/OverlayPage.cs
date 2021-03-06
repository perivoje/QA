﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejan_QA.Pages
{
    class OverlayPage
    {
        readonly IWebDriver driver;
        public By proceedToCheckout = By.CssSelector(".btn-default[title='Proceed to checkout']");

        public OverlayPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("layer_cart")));
        }


    }
}
