using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTutorial
{
    public class Class1
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.deviantart.com/");
        }
    }
}
