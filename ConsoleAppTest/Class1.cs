using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleAppTest
{
    class DriverCommand
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.google.com.au/";
            String Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page is: " + Title);
            Console.WriteLine("Length of the Title is : " + TitleLength);
            String PageURL = driver.Url;
            int URLLength = PageURL.Length;
            Console.WriteLine("URL of the page is : " + PageURL);
            Console.WriteLine("Length of the URL is: " + URLLength);
            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            Console.WriteLine("Page Source of the page is : " + PageSource);
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);
            driver.Close();

        }
    }
}
