using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
 
namespace Webdemo.PageObjects
{
    class LoginResultsPage
    {
        private IWebDriver driver;
 
        public LoginResultsPage(IWebDriver driver)
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

/*
        public string PageTitle()
        {
            return driver.Title;
        }


        public bool authenticated() {
            return contains("Login succeeded");
        }
*/
    }

}