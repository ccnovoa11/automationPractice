using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using automationpractice.PageObjects;

namespace automationpractice
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Register
    {
        IWebDriver driver;
        WebDriverWait wait;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0,0,20));
        }

        [TestMethod]
        public void RegisterTest()
        {

            HomePage homePage = new HomePage(driver, wait);
            SignInPage signInPage = new SignInPage(driver);
            CreateAccountPage createAccountPage = new CreateAccountPage(driver);
            MyAccountPage myAccountPage = new MyAccountPage(driver);


            homePage.GoToScreen();
            homePage.ClickSignIn();

            int i = new Random().Next(0, 150);
            signInPage.CreateAccount("FakeEmail" + i + "@fake.com");
            
            
            createAccountPage.FillPersonalInfo("Saltiago", "Ready", "PeraNoManzana");
            createAccountPage.FillDropdowns("4","4", "1995");
            createAccountPage.FillAddress("AFakeCompany", "Street fake", "123", "New Fake", "32", "10013", "21", "12345678", "MyFakeAlias");

            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", myAccountPage.GetLogInMsg());
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
