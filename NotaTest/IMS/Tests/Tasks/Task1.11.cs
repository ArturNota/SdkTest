/*
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

namespace IMS.Tests.Task1_11
{
    
    public class Task1_11
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
            extent.StartedReporterList.Add(htmlReporter);
        }

        [TestCase]
        public void TestTask1_11()
        {
            test = null;

            test = extent.CreateTest("Nota").Info("еве");

            goTo.LoginPage(ConfigurationManager.AppSettings["LoginPage"]);
            loginObjects.InputLoginOper();
            loginObjects.InputPwdOper();
            loginObjects.LoginButton();
            goTo.IncidentPage(ConfigurationManager.AppSettings["IncidentPage"]);

            goTo.IncidentPageTask(ConfigurationManager.AppSettings["IncidentPageForOper"]);
            //incidentPage.CreateTask();
            //incidentPage.NameOfTask();
            //incidentPage.SaveTaskWithOutFrame();
            test.Log(Status.Pass, "Test Pass");


            System.Threading.Thread.Sleep(10000);



        }

        [TestCase]
        public void TestTask1_1111()
        {
            test = null;

            test = extent.CreateTest("Nota2").Info("еве");

            goTo.LoginPage(ConfigurationManager.AppSettings["LoginPage"]);
            loginObjects.InputLoginOper();
            loginObjects.InputPwdOper();
            loginObjects.LoginButton();
            goTo.IncidentPage(ConfigurationManager.AppSettings["IncidentPage"]);

            goTo.IncidentPageTask(ConfigurationManager.AppSettings["IncidentPageForOper"]);
            //incidentPage.CreateTask();
            //incidentPage.NameOfTask();
            //incidentPage.SaveTaskWithOutFrame();
            test.Log(Status.Pass, "Test Pass");


            System.Threading.Thread.Sleep(10000);
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
*/