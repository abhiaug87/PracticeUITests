using NUnit.Framework;
using PracticeUITests.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using PracticeUITests.PageObjects;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Interactions;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace PracticeUITests.Steps
{
    [Binding]
    public class Stepdefinition : BaseClass
    {
        Pageobjects po = new Pageobjects(Driver);
        WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
        JSON read = new JSON();

    }
}
