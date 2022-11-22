using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Automation_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By googleResultText = By.XPath(".//h2//span[text()='Street Fighter V']");
            By googleIAgreeButton = By.Id("L2AGLb");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.co.uk");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleIAgreeButton).Click();

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);

            var actualResultText = webDriver.FindElement(googleResultText);

            Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V"));

            webDriver.Quit();
        }
    }
}
