using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.WebDriver.WaitExtensions;

namespace _4MeLabs.BookCreation.Selenium.Util
{
    public static class WebDriverExtensions
    {
        public static IWebElement WaitForDisplayed(this IWebDriver driver, By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            var element = wait.Until(x => driver.FindElement(selector));

            return element;
        }
    }
}
