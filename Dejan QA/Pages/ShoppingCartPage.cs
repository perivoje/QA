using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejan_QA.Pages
{
    class ShoppingCartPage
    {
        readonly IWebDriver driver;
        public By addToCart = By.Id("add_to_cart");

        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("add_to_cart")));
        }
    }

}
