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
        




        [SetUp]

        public void Test()
        {
            
           
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
