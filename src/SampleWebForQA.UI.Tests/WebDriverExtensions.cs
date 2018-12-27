using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SampleWebForQA.UI.Tests
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElementByCssSelector(
            this RemoteWebDriver driver, 
            string cssSelector, 
            bool throwException)
        {
            IWebElement webElement = null;
            try
            {
                webElement = driver.FindElementByCssSelector(cssSelector);
            }
            catch (Exception exception)
            {
                if (throwException)
                {
                    throw exception;
                }
            }

            return webElement;
        }
    }
}
