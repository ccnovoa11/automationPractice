using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using automationpractice.PageObjects;

namespace automationpractice
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class SignIn
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
        public void SignInTest()
        {

            HomePage homePage = new HomePage(driver, wait);
            SignInPage signInPage = new SignInPage(driver);
            MyAccountPage myAccountPage = new MyAccountPage(driver);

            
            homePage.GoToScreen();
            homePage.ClickSignIn();
            
            signInPage.FillSignIn("anEmail3@fake.com", "Password");
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", myAccountPage.GetLogInMsg());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
