using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ExtentReportsDemo
{
    [TestFixture]
    public class BasicReport2
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void StartReport()
        {

            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Reports\\MyOwnReport.html";

            extent = new ExtentReports(reportPath, false);
            extent
            .AddSystemInfo("Host Name", "Artur")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Artur G");
            extent.LoadConfig(projectPath + "extent-config.xml");
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
            driver.Manage().Window.Maximize();
        }
        

        [Test]
        public void DemoReportPass2()
        {
            
            driver.Navigate().GoToUrl("https://www.youtube.com/");
        }

        [Test]
        public void DemoReportFail()
        {
            test = extent.StartTest("DemoReportFail");
            Assert.IsTrue(false);
            test.Log(LogStatus.Pass, "Assert Fail as condition is False");
        }

        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
            extent.EndTest(test);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}