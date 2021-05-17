using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Webdemo.PageObjects;

namespace SeleniumWebdriver
{
    [TestFixture]
    public class WebdemoTests
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

        //[Test, Property("Requirement", "XT-10")]
        [Test, Property("Requirement", "CALC-2")]
        public void ValidLogin()
        {
            LoginPage loginPage = new LoginPage(driver).Open();
            LoginResultsPage loginResultsPage = loginPage.Login("demo", "mode");
            Assert.AreEqual(loginResultsPage.Title, "Welcome Page");
            Assert.IsTrue(loginResultsPage.Contains("Login succeeded"));
        }

        //[Test, Property("Requirement", "XT-10")]
        [Test, Property("Requirement", "CALC-2")]
        public void InvalidLogin()
        {
            LoginPage loginPage = new LoginPage(driver).Open();
            LoginResultsPage loginResultsPage = loginPage.Login("demo", "invalid");
            Assert.AreEqual(loginResultsPage.Title, "Error Page");
            Assert.IsTrue(loginResultsPage.Contains("Login failed"));
        }

    }
}
