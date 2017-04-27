using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTest_Automation
{
    [TestClass]
    public class UnitTest3
    {
        IWebDriver driver;



        [TestInitialize]
            public void SetupTest()
            {
                string path = Environment.GetEnvironmentVariable("chromedriver");
                driver = new ChromeDriver(path);


            }

            [TestMethod]
            public void Demo()
            {
                driver.Navigate().GoToUrl("http://demoqa.com/registration/");
            }
        }
    }

            
        
