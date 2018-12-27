using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SampleWebForQA.UI.Tests
{
    public abstract class FunctionTests
    {
        private string currentDirectory;
        
        protected abstract RemoteWebDriver Driver { get; }

        [TestMethod]
        public void ExpectToOpenHomePage()
        {
            using (Driver)
            {
                Driver.Navigate().GoToUrl(@"http://localhost:5005");
                bool titleContainHomoPage =
                    Driver.Title.Contains("Home page", StringComparison.InvariantCultureIgnoreCase);
                Assert.IsTrue(titleContainHomoPage);
            }
        }

        [TestMethod]
        public void ExpectCookiePolicyContainerToDoNotExistAfterAcceptPolicyAgreements()
        {
            const string AcceptCookiesButtonSelector = "#cookieConsent button:not(.navbar-toggle)";
            using (Driver)
            {
                Driver.Navigate().GoToUrl(@"http://localhost:5005");
                IWebElement acceptButton = Driver.FindElementByCssSelector(AcceptCookiesButtonSelector, false);
                if (acceptButton == null)
                {
                    throw new NullReferenceException("Cannot find accept button!");
                }

                acceptButton.Click();

                Driver.Navigate().Refresh();
                acceptButton = Driver.FindElementByCssSelector(AcceptCookiesButtonSelector, false);
                Assert.IsNull(acceptButton);
            }
        }

        protected string GetExecutingDirectory()
        {
            if (string.IsNullOrWhiteSpace(this.currentDirectory))
            {
                string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
                this.currentDirectory = System.IO.Path.GetDirectoryName(assemblyLocation);
            }

            return currentDirectory;
        }
    }
}
