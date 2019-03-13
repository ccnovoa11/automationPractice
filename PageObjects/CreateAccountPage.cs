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
    class CreateAccountPage
    {
        private IWebDriver driver;


        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "id_gender1")]
        private IWebElement genderButton;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        private IWebElement customerFirstNameField;

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        private IWebElement customerLastNameField;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "days")]
        private IWebElement daysDropdown;

        [FindsBy(How = How.Id, Using = "months")]
        private IWebElement monthsDropdown;

        [FindsBy(How = How.Id, Using = "years")]
        private IWebElement yearsDropdown;

        [FindsBy(How = How.Id, Using = "company")]
        private IWebElement companyField;

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement addressField;

        [FindsBy(How = How.Id, Using = "address2")]
        private IWebElement address2Field;

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement cityField;

        [FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement stateDropdown;

        [FindsBy(How = How.Id, Using = "postcode")]
        private IWebElement postalCodeField;

        [FindsBy(How = How.Id, Using = "id_country")]
        private IWebElement countryDropdown;

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        private IWebElement phoneField;

        [FindsBy(How = How.Id, Using = "alias")]
        private IWebElement aliasField;

        [FindsBy(How = How.Id, Using = "submitAccount")]
        private IWebElement submitButton;

        public void FillPersonalInfo(string firstName, string lastName, string password)
        {
            Actions.WaitForElement(this.driver, By.Id("id_gender1"));
            //waiter.Until(ExpectedConditions.ElementToBeClickable(genderButton));
            Actions.ClickOn(this.driver, genderButton);
            Actions.TypeField(this.driver, customerFirstNameField, firstName);
            Actions.TypeField(this.driver, customerLastNameField, lastName);
            Actions.TypeField(this.driver, passwordField, password);
        }

        public void FillDropdowns(string valueDays, string valueMonths, string valueYears)
        {
            Actions.SelectDropdown(this.driver, daysDropdown, valueDays);
            Actions.SelectDropdown(this.driver, monthsDropdown, valueMonths);
            Actions.SelectDropdown(this.driver, yearsDropdown, valueYears);
        }

        public void FillAddress(string company, string address1, string address2, string city, string state, string postal, string country, string phone, string alias)
        {
            Actions.TypeField(this.driver, companyField, company);
            Actions.TypeField(this.driver, addressField, address1);
            Actions.TypeField(this.driver, address2Field, address2);
            Actions.TypeField(this.driver, cityField, city);
            Actions.SelectDropdown(this.driver, stateDropdown, state);
            Actions.SelectDropdown(this.driver, countryDropdown, country);
            Actions.TypeField(this.driver, postalCodeField, postal);
            Actions.TypeField(this.driver, phoneField, phone);
            Actions.TypeField(this.driver, aliasField, alias);
            Actions.ClickOn(this.driver, submitButton);
        }
    }
}
