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
    class MyAccountPage
    {

        private IWebDriver driver;


        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "info-account")]
        private IWebElement welcomeMsg;

        public string GetLogInMsg()
        {
            return welcomeMsg.Text;
        }
    }
}
