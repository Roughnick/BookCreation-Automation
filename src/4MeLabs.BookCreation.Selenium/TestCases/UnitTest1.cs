using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace _4MeLabs.BookCreation.Selenium
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver Driver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            var path = Path.GetFullPath("./");
            Driver = new ChromeDriver(path);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Driver.Navigate().GoToUrl("http://tohru.4melabs.com/ikigai/books.php");
            Driver.Quit();
        }
    }
}
