﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejan_QA.Pages
{

    class AuthenticationPage
    {
        readonly IWebDriver driver;

        public By username = By.Id("email");
        public By password = By.Id("passwd");
        public By signInbtn = By.Id("SubmitLogin");
        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("authentication")));
        }
    }
}
