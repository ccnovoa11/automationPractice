using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationpractice.Framework
{
    class Actions
    {
        public static void ClickOn(IWebDriver driver, IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", element);
            }
        }

        public static IWebElement WaitForElement(IWebDriver driver, By by, int seconds = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until((d) =>
            {
                return d.FindElement(by);
            });
        }

        public static void TypeField(IWebDriver driver, IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void SelectDropdown(IWebDriver driver, IWebElement element, string value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }
    }
}
