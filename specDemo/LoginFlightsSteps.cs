using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace specDemo
{
    [Binding]
    public class LoginFlightsSteps
    {
        public IWebDriver drive;
        [Given(@"User is at Flights Home page")]
        public void GivenUserIsAtFlightsHomePage()
        {
            drive = new ChromeDriver("C:\\Users\\sreenivasa.munagala\\Desktop\\CsharpProject\\specDemo\\specDemo\\Drivers");
            drive.Url = "http://blazedemo.com/index.php";
            drive.Manage().Window.Maximize();
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Enter departure as well destination")]
        public void GivenEnterDepartureAsWellDestination()
        {
            drive.FindElement(By.XPath("//select/child::option[@value='Portland']")).Click();
            //drive.Manage().Timeouts().ImplicitWait(ti
            Thread.Sleep(3000);
            drive.FindElement(By.XPath("//select/child::option[@value='London']")).Click();
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"When I press FindFilghts")]
        public void WhenWhenIPressFindFilghts()
        {
            drive.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(5000);
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be shown to the user")]
        public void ThenTheResultShouldBeShownToTheUser()
        {
            Boolean val = drive.FindElement(By.XPath("//h3")).Displayed;
           // Assert.assertEqulals()
           // ScenarioContext.Current.Pending();
        }
    }
}
