using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Webdemo.PageObjects
{
    class LoginPage
    {
        String homepage_url = "http://robotwebdemo.herokuapp.com/";

        [FindsBy(How = How.Id, Using = "username_field")]
        [CacheLookup]
        private IWebElement usernameElement;
 
        [FindsBy(How = How.Id, Using = "password_field")]
        [CacheLookup]
        private IWebElement passwordElement;

        [FindsBy(How = How.Id, Using = "login_button")]
        [CacheLookup]
        private IWebElement submitButtonElement;
 

        private IWebDriver driver;
        private WebDriverWait wait;
 
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public LoginPage Open()
        {
            driver.Navigate().GoToUrl(homepage_url);
            return this;
        }

        public LoginResultsPage Login(string username, string password)
        {
            usernameElement.SendKeys(username);
            passwordElement.SendKeys(password);
            submitButtonElement.Submit();
            return new LoginResultsPage(driver);
        }

/*
        public String PageTitle()
        {
            return driver.Title;
        }


        public bool IsVisible
        {
            get
            {
                try
                {
                    return StartHereButton.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
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