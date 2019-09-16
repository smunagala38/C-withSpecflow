using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.IO;
using System;

namespace specDemo
{
    [Binding]
    public class LogIn_Steps
    {
        public IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            string curDir = "";

            curDir = Directory.GetCurrentDirectory();

            Console.WriteLine("Current Directory is :\n" + curDir);
            String a = Environment.CurrentDirectory;
            Console.WriteLine(a);
            String b = Directory.GetParent(a).FullName;
            //String c = Directory.GetParent(b).FullName;

            driver = new ChromeDriver(b + "\\specDemo\\Drivers");
            driver.Url = "http://www.store.demoqa.com";
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }

        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            driver.FindElement(By.Id("log")).SendKeys("testuser_1");
            driver.FindElement(By.Id("pwd")).SendKeys("Test@123");
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            //This Checks that if the LogOut button is displayed
            true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

