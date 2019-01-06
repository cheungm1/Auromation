using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ConsoleAppTest
{
    class WebTest1
    {
     //demo using git
        static void Main(string[] args){ }

        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void StartUpApplication()
        {
            driver.Url = "https://www.wikipedia.org/";
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
