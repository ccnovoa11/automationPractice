using System;
using automationpractice.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    [TestClass]
    public class ContactUs
    {
        IWebDriver driver;
        WebDriverWait wait;


        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
        }

        [TestMethod]
        public void ContactUsTest()
        {

            HomePage homePage = new HomePage(driver, wait);
            ContactUsPage contactUsPage = new ContactUsPage(driver);

            homePage.GoToScreen();
            homePage.ClickContactUs();

            contactUsPage.Fillform("hola@mailinator.com", "1012252", "this is a test for automation");
            Assert.AreEqual("Your message has been successfully sent to our team.", contactUsPage.GetSuccessMsg());
        }

        [TestCleanup]
        public void TestCleanup()
        {
           driver.Quit();
        }
    }
}
