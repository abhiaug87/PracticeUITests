﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PracticeUITests.PageObjects
{
    public class Pageobjects
    {
        public Pageobjects(IWebDriver driver)
        {
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='fullHeader']/nav/div[1]/wnz-quick-nav/nav/ul/li[5]/a")]
        public IWebElement signin;

        [FindsBy(How = How.CssSelector, Using = "input#loginID.ng-star-inserted")]
        public IWebElement username;

        [FindsBy(How = How.CssSelector, Using = "input#password")]
        public IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "button.gigya-input-submit")]
        public IWebElement login;


    }
}
