using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;



namespace specDemo.StepDef
{
    [Binding]
    public class SampleTestCases
    {
        public IWebDriver driver;   
        [Given(@"I have Launched the chrme browser")]
        public void GivenIHaveLaunchedTheChrmeBrowser()
        {
            string curDir = "";

            curDir = Directory.GetCurrentDirectory();

            Console.WriteLine("Current Directory is :\n" + curDir);
            String a = Environment.CurrentDirectory;
            Console.WriteLine(a);
            String b = Directory.GetParent(a).FullName;
            //String c = Directory.GetParent(b).FullName;

            driver = new ChromeDriver(b + "\\specDemo\\Drivers");
            Thread.Sleep(3000);
        }

        [Given(@"given the valid URL")]
        public void GivenGivenTheValidURL()
        {
            driver.Url = "http://www.store.demoqa.com";
            Thread.Sleep(3000);
        }

        [When(@"Click on User Name")]
        public void WhenClickOnUserName()
        {
            driver.FindElement(By.XPath("//a[@class='noo-search']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@type='search']")).SendKeys("Dress");
            Thread.Sleep(3000);
        }

        [Then(@"User should able to see the application")]
        public void ThenUserShouldAbleToSeeTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
