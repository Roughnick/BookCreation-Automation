using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using _4MeLabs.BookCreation.Selenium.Util;

namespace _4MeLabs.BookCreation.Selenium.PageObjects.BookPageObjects
{
    public class BookPage : PageObject
    {
        public BookPageElementMap Map => new BookPageElementMap();

        public BookPage(IWebDriver driver) : base(driver) { }

        public void AddNewBook(string bookName)
        {
            _driver.WaitForDisplayed(Map.AddBookBtn).Click();
        }
    }
}
