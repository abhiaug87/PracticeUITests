using OpenQA.Selenium;
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

        [FindsBy(How = How.Id, Using = "loginID")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "button.gigya-input-submit")]
        public IWebElement login;

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement search;

        [FindsBy(How = How.CssSelector, Using = "h2#product-282765-title")]
        public IWebElement product1;

        [FindsBy(How = How.CssSelector, Using = "button#searchIcon")]
        public IWebElement searchicon;

        [FindsBy(How = How.XPath, Using = "/html/body/wnz-content/div[2]/wnz-search/div[2]/main/product-grid/product-stamp-grid[1]/cdx-card/footer/product-add-to-trolley/button")]
        public IWebElement trolley;
    }
}
