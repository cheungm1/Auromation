using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace ConsoleAppTest
{
    class PractiseBasic
    {
        [Test]
        public void TestRadioButton()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = @"file:///C:/0_TestData/Test1.htm";
            var radioButton = driver.FindElements(By.Name("color"))[1];
            radioButton.Click();
            var buttons = driver.FindElements(By.Name("color"));
            foreach (var aButton in buttons)
            {
                if (aButton.Selected)
                    Console.WriteLine(aButton.GetAttribute("value"));
            }
            var checkbox = driver.FindElement(By.Id("check1"));
            checkbox.Click();
            var select = driver.FindElement(By.Id("selectName"));
            var name = new SelectElement(select);
            name.SelectByText("Joshua");
            var outerTable = driver.FindElement(By.TagName("table"));
            var innerTable = driver.FindElement(By.TagName("table"));
            var row = innerTable.FindElements(By.TagName("td"))[0];
            Console.WriteLine(row.Text);
            driver.Close();
        }
    }
}