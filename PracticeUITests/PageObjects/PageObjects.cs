using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PracticeUITests.PageObjects
{
    public class Pageobjects
    {
        public Pageobjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
