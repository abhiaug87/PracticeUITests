using PracticeUITests.Steps;
using System.Linq;
using TechTalk.SpecFlow;
using System;
using System.Drawing.Imaging;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeUITests.Utilities
{
    [Binding]
    public class Hooks : BaseClass
    {
        [BeforeScenario]

        public void BeforeScenario()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.ChromeBrowser);
            }
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("FireFox"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.FireFoxBrowser);
            }
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Edge"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.EdgeBrowser);
            }
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Headless"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.HeadlessBrowser);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (NUnit.Framework.TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string pathfile = Path.Combine(NUnit.Framework.TestContext.CurrentContext.WorkDirectory + @"\\Screenshot", "Screenshot.JPG" + "_" +
                DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)"));
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile(pathfile, ScreenshotImageFormat.Jpeg);
            }
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
