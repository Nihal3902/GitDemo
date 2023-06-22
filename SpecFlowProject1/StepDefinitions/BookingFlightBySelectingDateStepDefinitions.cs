using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BookingFlightBySelectingDateStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"go to url and login")]
        public void GivenGoToUrlAndLogin()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/dropdownsPractise/";
        }

        [When(@"select city of diparture")]
        public void WhenSelectCityOfDiparture()
        {
            /*IWebElement departCity=  driver.FindElement(By.Id("ctl00_mainContent_ddl_originStation1"));
             SelectElement s = new SelectElement(departCity);
             s.SelectByValue("DEL");*/
            driver.FindElement(By.Id("ctl00_mainContent_ddl_originStation1_CTXT")).SendKeys("delhi");
            Thread.Sleep(1000);


           
        }

        [When(@"select city of arrival")]
        public void WhenSelectCityOfArrival()
        {
            /*IWebElement arrivalCity = driver.FindElement(By.Id("ctl00_mainContent_ddl_destinationStation1"));
            SelectElement s = new SelectElement(arrivalCity);
            s.SelectByValue("BOM");*/
            driver.FindElement(By.Id("ctl00_mainContent_ddl_destinationStation1_CTXT")).SendKeys("mumbai");
            Thread.Sleep(1000);
        }

        [When(@"select departur date")]
        public void WhenSelectDeparturDate()
        {
            IList<IWebElement> months = driver.FindElements(By.CssSelector("div span[class='ui-datepicker-month']"));
            foreach(IWebElement month in months)
            { 
                if(month.Text.Equals("June"))
                {
               
                    IList<IWebElement> dates =driver.FindElements(By.CssSelector("tr td[data-handler='selectDay']"));
                    foreach (IWebElement date in dates)
                    {
                       if( date.Text.Equals("14"))
                        {
                            date.Click();
                            break;
                        }
                    }
                
                }

            }
        }

        [Then(@"go and click search")]
        public void ThenGoAndClickSearch()
        {
            driver.FindElement(By.CssSelector("div span input[value='Search']")).Click();   
            
        }
    }
}
