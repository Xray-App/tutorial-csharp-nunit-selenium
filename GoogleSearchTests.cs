using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Google.PageObjects;

namespace SeleniumWebdriver
{
    [TestFixture]
    public class GoogleSearchTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox"); // Bypass OS security model, to run in Docker
            options.AddArgument("--headless"); 
            driver = new ChromeDriver(options);
        }


        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [Test, Property("Requirement", "XT-9")]
        public void BasicTextSearch()
        {

            HomePage homePage = new HomePage(driver).Open();
            //Assert.AreEqual("Google", homePage.PageTitle());
            SearchResultsPage searchResultsPage = homePage.Search("Selenium OpenQA");
            //searchResultsPage.results.first
            Assert.IsTrue(searchResultsPage.Contains("www.selenium.dev"));
        }

        [Test, Property("Requirement", "XT-9")]
        public void BasicTextSearchNoPOM()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            Assert.AreEqual("Google", driver.Title);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Selenium OpenQA");
            query.Submit();
            Assert.IsTrue(driver.PageSource.Contains("www.selenium.dev"));
        }

    }
}
