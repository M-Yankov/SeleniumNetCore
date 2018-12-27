using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace SampleWebForQA.UI.Tests
{
    [TestClass]
    public class EdgeTests : FunctionTests
    {
        private RemoteWebDriver edgeDriver;

        [TestInitialize]
        public void InitializeDriver()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddAdditionalCapability("InPrivate", true);
            this.edgeDriver = new EdgeDriver(this.GetExecutingDirectory(), options);
        }

        protected override RemoteWebDriver Driver => this.edgeDriver;
    }
}
