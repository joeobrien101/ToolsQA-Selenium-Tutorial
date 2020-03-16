using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.Selenium_Basics
{
    class DriverCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver(@"F:/Selenium");

            driver.Url = "http://www.demoqa.com";

            String Title = driver.Title;

            int TitleLength = driver.Title.Length;

            Console.WriteLine("Title of the page is " + Title);
            Console.WriteLine("Length of the title is " + TitleLength);

            String PageUrl = driver.Url;
            int UrlLength = driver.Url.Length;

            Console.WriteLine("Url of page is " + PageUrl);
            Console.WriteLine("Length of url is " + UrlLength);

            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;


            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

            driver.Quit();

        }
    }
}
