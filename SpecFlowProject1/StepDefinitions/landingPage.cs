using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    public class landingPage
    {
        private IWebDriver driver;
        public landingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        /* driver.FindElement(By.CssSelector("input[name='search_query']")).SendKeys("testers Talk");
         driver.FindElement(By.Id("search-icon-legacy")).Click();*/
        [FindsBy(How = How.CssSelector, Using = "input[name='search_query']")]
        private IWebElement searchBox;

        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        private IWebElement searchEnter;
        public void SearchPage()
        {
            searchBox.SendKeys("mumbikar nikhil");
            searchEnter.Click();

        }


    }
}
