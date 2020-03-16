using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.Selenium_Basics
{
    class FindElementCommands_2
    {

        [Test]
        public void Test()
        {
            // Create a new instance of the FireFox driver
            IWebDriver driver = new FirefoxDriver();

            // Launch the Online Store WebSite
            driver.Url = ("http://toolsqa.com/Automation-practice-form/");

            // Click on "Partial Link Text" link
            driver.FindElement(By.PartialLinkText("Partial")).Click();
            Console.WriteLine("Partial Link Test Pass");

            // Convert element in to a string 
            String sClass = driver.FindElements(By.TagName("button")).ToString();
            Console.WriteLine(sClass);

            // Click on "Link Text" link
            driver.FindElement(By.LinkText("Link Test")).Click();
            Console.WriteLine("Link Test Pass");
        }
    }
}
