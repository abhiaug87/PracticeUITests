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
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace PracticeUITests.Utilities
{
    [Binding]
    public class Hooks : BaseClass
    {

        private static ExtentTest featurename, scenario;
        private static ExtentReports htmlreport;

        [BeforeTestRun]
        public static void InitializeReports()
        {
            var reports = new ExtentHtmlReporter(Path.Combine(NUnit.Framework.TestContext.CurrentContext.WorkDirectory + @"\\TestRunReport", "index.html"));
            reports.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlreport = new ExtentReports();
            htmlreport.AttachReporter(reports);

        }

        [AfterTestRun]
        public static void PublishReports()
        {
            htmlreport.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featurename = htmlreport.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        public static void AfterStep()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        }

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
            scenario = featurename.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
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
