using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejan_QA.Pages
{
    class PLPPage
    {
        public IWebDriver driver;

        public By firstDress = By.CssSelector(".product_img_link .replace-2x");

        public PLPPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".container .breadcrumb [title = 'Women']")));

        }

    }
}
