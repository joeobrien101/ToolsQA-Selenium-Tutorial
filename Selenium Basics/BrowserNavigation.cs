using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.Selenium_Basics
{
    class BrowserNavigation
    {

        [Test]
        public void BrowserNavigationTest()
        {
            IWebDriver driver = new FirefoxDriver(@"F:/Selenium");

            driver.Url = "https://www.demoqa.com";

            driver.FindElement(By.XPath(".//*[@id=’menu-item-374′]/a")).Click();

            driver.Navigate().Back();

            driver.Navigate().Forward();

            driver.Navigate().GoToUrl("https://www.demoqa.com");

            driver.Navigate().Refresh();
        }
    }
}
