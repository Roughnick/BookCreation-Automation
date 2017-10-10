﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _4MeLabs.BookCreation.Selenium.PageObjects.BookPageObjects
{
    public class BookPage : PageObject
    {
        public BookPageElementMap Map => new BookPageElementMap();

        public BookPage(IWebDriver driver) : base(driver) { }

        public void AddNewBook()
        {

        }
    }
}
