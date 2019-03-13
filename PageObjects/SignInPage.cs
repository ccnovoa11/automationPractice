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
    class SignInPage
    {
        private IWebDriver driver;


        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailfield;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement emailCreateField;
        
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement signInButton;

        [FindsBy(How = How.ClassName, Using = "info-account")]
        private IWebElement logInMsg;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement createAccountButton;


        public void FillSignIn(string email, string password)
        {
            Actions.TypeField(this.driver, emailfield, email);
            Actions.TypeField(this.driver, passwordField, password);
            Actions.ClickOn(this.driver, signInButton);
        }

        public void CreateAccount (string email)
        {
            Actions.TypeField(this.driver, emailCreateField, email);
            Actions.ClickOn(this.driver, createAccountButton);

        }
    }
}
