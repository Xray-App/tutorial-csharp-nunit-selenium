using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
 
namespace Google.PageObjects
{
    class SearchResultsPage
    {
        private IWebDriver driver;
 
        public SearchResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public bool Contains(String text) {
            return driver.PageSource.Contains(text);
        }

        public string Title
        {
            get
            {
                return driver.Title;
            }
        }
    }
}