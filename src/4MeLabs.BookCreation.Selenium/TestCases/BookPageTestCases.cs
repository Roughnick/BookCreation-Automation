using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using _4MeLabs.BookCreation.Selenium.PageObjects.BookPageObjects;

namespace _4MeLabs.BookCreation.Selenium
{
    [TestClass]
    public class BookPageTestCases
    {
        static IWebDriver Driver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            var path = Path.GetFullPath("./");
            Driver = new ChromeDriver(path);
        }

        [TestMethod]
        public void AddNewBook()
        {
            var bookStuff = new BookPage(Driver);
            bookStuff.GoToUrl("http://tohru.4melabs.com/ikigai/books.php");
            bookStuff.AddNewBook("AutomationTest");
            Driver.Quit();
        }
    }
}
