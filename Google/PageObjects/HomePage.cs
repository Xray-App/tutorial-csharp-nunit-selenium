using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Google.PageObjects
{
    class HomePage
    {
        String homepage_url = "https://www.google.com";
        [FindsBy(How = How.Name, Using = "q")]
        [CacheLookup]
        private IWebElement elem_search_text;
 

        [FindsBy(How = How.Name, Using = "btnI")]
        [CacheLookup]
        private IWebElement elem_submit_button;
 

        private IWebDriver driver;
        private WebDriverWait wait;
 
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public HomePage Open()
        {
            driver.Navigate().GoToUrl(homepage_url);
            return this;
        }

        public SearchResultsPage Search(string searchString)
        {
            elem_search_text.SendKeys(searchString);
            //wait.Until(ExpectedConditions.ElementToBeClickable(elem_submit_button)).Submit();
            elem_search_text.Submit();
            return new SearchResultsPage(driver);
        }

/*
        public String PageTitle()
        {
            return driver.Title;
        }
*/
        public string Title
        {
            get
            {
                return driver.Title;
            }
        }

    }
}