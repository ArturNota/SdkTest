using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System.Linq;
using System.Configuration;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
using NotaTest.IMS.PageObjects;
using NotaTest.IMS.Login;
using System.Threading;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NotaTest;

namespace IMS.Tests.Task1_22
{
    [TestFixture]
    public class Task1_22
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private LoginObjects loginObjects;
        private GoTo goTo;
        private IncidentPage incidentPage;
        public static ExtentTest test;
        public static ExtentReports extent;



        [SetUp]

        public void Test()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
            driver.Manage().Window.Maximize();
            loginObjects = new LoginObjects(driver);
            goTo = new GoTo(driver);
            incidentPage = new IncidentPage(driver);


        }

        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\nilidalg\source\repos\NotaTest\NotaTest\Reports07\12\index.html");

            extent.AttachReporter(htmlReporter);

        }


        [Test]
        public void TestTask1_22()
        {
            test = null;
           
            test = extent.CreateTest("Тест раздела задач").Info("Проверка прав");

            goTo.LoginPage(ConfigurationManager.AppSettings["LoginPage"]);
            loginObjects.InputLoginOperReg();
            loginObjects.InputPwdOperReg();
            loginObjects.LoginButton();
            

            goTo.IncidentPageTask(ConfigurationManager.AppSettings["IncidentPageForTask"]);
            System.Threading.Thread.Sleep(1000);
            test.Log(Status.Pass, "Test Pass");



        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

    }
}
