using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.Selenium_Basics
{
 
    class FindElementCommands
    {

        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver(@"F:/Selenium");

            driver.Url = "http://toolsqa.com/automation-practice-form/";

            // Type Name in the FirstName text box
            driver.FindElement(By.Name("firstname")).SendKeys("Joe");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("lastname")).SendKeys("O'Brien");

            // Click on the Submit button
            driver.FindElement(By.Id("submit")).Click();
        }
    }
}
