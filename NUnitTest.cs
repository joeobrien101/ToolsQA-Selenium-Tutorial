using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;


        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver(@"F:\Selenium");
        }

        [Test]
        public void OpenTestApp()
        {
            driver.Url = "http://www.demoqa.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
