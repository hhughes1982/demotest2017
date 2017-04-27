using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace UnitTest_Automation
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            string path = Environment.GetEnvironmentVariable("chromedriver");
            driver = new ChromeDriver(path);
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/registration/");

            // use when I need to use a drop down menu
            //SelectElement dropdown = new SelectElement
            //first name
            driver.FindElement(By.XPath("//*[@id='name_3_firstname']")).SendKeys("Heather");
            Thread.Sleep(1000);
            //last name
            driver.FindElement(By.XPath("//*[@id='name_3_lastname']")).SendKeys("Clark");
            Thread.Sleep(1000);
            //marital status
            driver.FindElement(By.XPath("//*[@id='pie_register']/li[2]/div/div/input[1]")).Click();
            Thread.Sleep(1000);
            //hobby
            driver.FindElement(By.XPath("//*[@id='pie_register']/li[3]/div/div[1]/input[1]")).Click();
            Thread.Sleep(1000);
            //country
            SelectElement dropdowncountry = new SelectElement(driver.FindElement(By.Id("dropdown_7")));
            dropdowncountry.SelectByText(("United States"));
            Thread.Sleep(1000);
            //date of birth
            SelectElement dropdownmonth = new SelectElement(driver.FindElement(By.Id("mm_date_8")));
            dropdownmonth.SelectByIndex((5));
            Thread.Sleep(1000);
            SelectElement dropdownday = new SelectElement(driver.FindElement(By.Id("dd_date_8")));
            dropdownday.SelectByValue(("5"));
            Thread.Sleep(1000);
            SelectElement dropdownyear = new SelectElement(driver.FindElement(By.Id("yy_date_8")));
            dropdownyear.SelectByValue(("1995"));
            Thread.Sleep(1000);
            //phone number
            driver.FindElement(By.Id("phone_9")).SendKeys("9122374545");
            Thread.Sleep(1000);
            //username
            driver.FindElement(By.Id("username")).SendKeys("HeadtherC1995*");
            Thread.Sleep(1000);
            //email
            driver.FindElement(By.Id("email_1")).SendKeys("heather1995**@gmail.com");
            Thread.Sleep(1000);
            //about yourself
            driver.FindElement(By.Id("description")).SendKeys("I am 41 year old mother of three boys and married to my best friend");
            Thread.Sleep(1000);
            //password
            driver.FindElement(By.Id("password_2")).SendKeys("Ilovepickles*");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("confirm_password_password_2")).SendKeys("Ilovepickles*");
            Thread.Sleep(1000);
            //submit
            driver.FindElement(By.Name("pie_submit")).Click();
            //verify thank you banner is present after you complete registration
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='post-49']/div/p")).Displayed);

            //verify "Thank you for your registration"         
            //String text = "Thank you for your registration";
            Assert.IsTrue(driver.FindElement(By.ClassName("piereg_message")).Text.Equals("Thank you for your registration"));


            //neg assertion
            Assert.IsFalse(driver.FindElement(By.ClassName("piereg_login_error")).Text.Equals("E-mail address already exists"));

            //String pagesource = driver.PageSource;
            //Assert.AreNotEqual("Email address already exists", pagesource);




        }
    }
}

