using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _4MeLabs.BookCreation.Selenium.PageObjects.BookPageObjects
{
    public class BookPageElementMap
    {
        public By NavigationHomeLogo => By.ClassName("navbar-brand");
        public By AddBookBtn => By.Id("add_book");
        public By BookTable => By.Id("book_list");
        public By NewRowAdded => By.XPath("//td[contains(.,'Just Now')]");
    }
}
