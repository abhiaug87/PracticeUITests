using NUnit.Framework;
using PracticeUITests.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using PracticeUITests.PageObjects;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Interactions;
using System;
using PracticeUITests.Utilities;
using Newtonsoft.Json;
using System.IO;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Windows;

namespace PracticeUITests.Steps
{
    [Binding]
    public class Stepdefinition : BaseClass
    {
        Pageobjects po = new Pageobjects(Driver);
        WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
        JSON read = new JSON();

        [Given(@"I have logged into the portal")]
        public void GivenIHaveLoggedIntoThePortal()
        {
            Driver.Navigate().GoToUrl(CommonConstants.ApplicationSettings.BaseUrl);
            po.signin.Click();
            po.username.SendKeys(read.jsonReader("../PracticeUITests/Data/TestData.json", "username"));
            po.password.SendKeys(read.jsonReader("../PracticeUITests/Data/TestData.json", "password"));
            po.login.Click();
            Sleep(2);
        }

        [Given(@"I choose to order items from the website")]
        public void GivenIChooseToOrderItemsFromTheWebsite()
        {
            wait.Until(Driver => Driver.FindElement(By.Id("search")));
            Assert.IsTrue(po.search.Displayed, "Search text field is not displayed");
            po.search.SendKeys(read.jsonReader("../PracticeUITests/Data/TestData.json", "item1"));
            Assert.IsTrue(po.searchicon.Displayed, "Search icon is not displayed");
            po.searchicon.Click();
            wait.Until(Driver => Driver.FindElement(By.CssSelector("h2#product-282765-title")));
            Assert.IsTrue(po.product1.Text.Contains(read.jsonReader("../PracticeUITests/Data/TestData.json", "product1")));
        }

        [When(@"I place an order")]
        public void WhenIPlaceAnOrder()
        {
            po.search.SendKeys(Keys.PageDown);
            Assert.IsTrue(po.trolley.Displayed, "Text field is not displayed");
            Assert.IsTrue(po.trolley.Text.Contains(read.jsonReader("../PracticeUITests/Data/TestData.json", "TrolleyText")));
            po.trolley.Click();
        }



    }
}
