using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.OpenSDK.Drivers.Web;
using OpenQA.Selenium.Remote;
namespace TestProject.OpenSDK.Examples.NUnit
{
    
    [TestFixture]
    public class ExampleTest
    {
        private ChromeDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            this.driver = new ChromeDriver(token: "5gSSrfTE2dPKdwFS-FnFlpEOZBR2spiRF7OeXB0-zNM1");
        }
        [Test]
        public void ExampleTestUsingChromeDriver()
        {
            this.driver.Navigate().GoToUrl("https://example.testproject.io");
            this.driver.FindElement(By.CssSelector("#name")).SendKeys("John Smith");
            this.driver.FindElement(By.CssSelector("#password")).SendKeys("12345");
            this.driver.FindElement(By.CssSelector("#login")).Click();
            Assert.IsTrue(this.driver.FindElement(By.CssSelector("#greetings")).Displayed);
        }
        [TearDown]
        public void CloseBrowser()
        {
            this.driver.Quit();
        }
    }
}