using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class YouTubeSearchFeatureStepDefinitions
    {
        public IWebDriver driver;
       
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            
            
        }

        [When(@"enter the url")]
        public void WhenEnterTheUrl()
        {
            driver.Url = "https://www.youtube.com/";
            
            
        }

        [Then(@"search for the testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            landingPage newPage = new landingPage(driver);
            newPage.SearchPage();
            

        }
    }
}
