using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Configuration;
using NotaTest.IMS.PageObjects;
using NotaTest.IMS.Login;
using TestProject.OpenSDK.Drivers.Web;
using ChromeDriver = TestProject.OpenSDK.Drivers.Web.ChromeDriver;

namespace IMS.Tests.Task1_13
{

    [TestFixture]
    public class Task1_13
    
    {
        
        private ChromeDriver driver;
        //private IWebDriver driver;
        //private WebDriverWait wait;
        private LoginObjects loginObjects;
        private GoTo goTo;
        private IncidentPage incidentPage;
        //public string Token = "5gSSrfTE2dPKdwFS-FnFlpEOZBR2spiRF7OeXB0-zNM1";




        [SetUp]

        public void Test()
        {
            
            //driver = new ChromeDriver(null, Token);
            
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
            driver.Manage().Window.Maximize();
            loginObjects = new LoginObjects(driver);
            goTo = new GoTo(driver);
            incidentPage = new IncidentPage(driver);
            



        }

        [Test]
        public void TestTask1_13()
        {

            goTo.LoginPage(ConfigurationManager.AppSettings["LoginPage"]);
            loginObjects.InputLoginOperReg();
            loginObjects.InputPwdOperReg();
            loginObjects.LoginButton();
            goTo.IncidentPage(ConfigurationManager.AppSettings["IncidentPage"]);


            //System.Threading.Thread.Sleep(10000);
            goTo.IncidentPageTask(ConfigurationManager.AppSettings["IncidentPageForOper"]);
            System.Threading.Thread.Sleep(10000);
            //incidentPage.CreateTask();
            // ДОБАВИТЬ ПРОВЕРКУ КНОПКИ

            

            


            



        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
