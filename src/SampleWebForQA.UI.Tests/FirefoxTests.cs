using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SampleWebForQA.UI.Tests
{
    [TestClass]
    public class FireFoxTests : FunctionTests
    {
        private RemoteWebDriver firefoxDriver;

        [TestInitialize]
        public void InitializeDriver() =>
            this.firefoxDriver = new FirefoxDriver(this.GetExecutingDirectory());

        protected override RemoteWebDriver Driver => this.firefoxDriver;
    }
}
