using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace PracticeUITests.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver InitiateWebDriver(string browser)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--window-size=1920,1080");
            chromeOptions.AddArguments("--allow-insecure-localhost");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--disable-gpu");
            chromeOptions.AddArguments("--no-sandbox");
            IWebDriver driver = null;
            if (browser.Equals(CommonConstants.DriverSettings.ChromeBrowser))
            {
               // driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome);
                 driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome, chromeOptions);

            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(CommonConstants.DriverSettings.DefaultWaitTime);
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
