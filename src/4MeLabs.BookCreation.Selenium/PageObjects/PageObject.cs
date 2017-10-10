using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _4MeLabs.BookCreation.Selenium.PageObjects
{
    public class PageObject
    {
        protected IWebDriver _driver;

        protected PageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToUrl(string siteUrl)
        {
            _driver.Navigate().GoToUrl(siteUrl);
        }
    }
}
