using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.Selenium_Basics
{
    class DriverCommands_2
    {

        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver(@"F:/Selenium");

            driver.Url = "http://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();

            driver.Close();
        }
    }
}
