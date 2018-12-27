using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace SampleWebForQA.UI.Tests
{
    [TestClass]
    public class InternerExplorerTests : FunctionTests
    {
        private RemoteWebDriver internetExplorerDriver;

        [TestInitialize]
        public void InitializeDriver()
        {
            this.internetExplorerDriver = new InternetExplorerDriver(this.GetExecutingDirectory());
            this.internetExplorerDriver.Manage().Cookies.DeleteAllCookies();
        }

        protected override RemoteWebDriver Driver => this.internetExplorerDriver;
    }
}
