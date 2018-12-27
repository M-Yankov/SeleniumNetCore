using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SampleWebForQA.UI.Tests
{
    [TestClass]
    public class ChromeTests : FunctionTests
    {
        private RemoteWebDriver chromeDriver;

        [TestInitialize]
        public void InitializeDriver() =>
            this.chromeDriver = new ChromeDriver(this.GetExecutingDirectory());

        protected override RemoteWebDriver Driver => this.chromeDriver;
    }
}
