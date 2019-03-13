using automationpractice.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationpractice.PageObjects
{
    class HomePage
    {

        private IWebDriver driver;
        private WebDriverWait waiter;


        public HomePage(IWebDriver driver, WebDriverWait waiter)
        {
            this.driver = driver;
            this.waiter = waiter;
            PageFactory.InitElements(driver, this) ;
        }

        [FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement optionContactUs;

        [FindsBy(How = How.ClassName, Using = "header_user_info")]
        private IWebElement optionSignIn;

        public void GoToScreen()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickContactUs()
        {
            Actions.ClickOn(driver, optionContactUs);
        }

        public void ClickSignIn()
        {
            waiter.Until(ExpectedConditions.ElementToBeClickable(optionSignIn));
            Actions.ClickOn(driver, optionSignIn);
        }


    }
}
