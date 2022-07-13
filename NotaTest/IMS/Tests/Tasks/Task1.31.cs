﻿using System;
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

namespace IMS.Tests.Task1_31
{
    public class Task1_31
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private LoginObjects loginObjects;
        private GoTo goTo;
        private IncidentPage incidentPage;




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

        [Test]
        public void TestTask1_31()
        {

            goTo.LoginPage(ConfigurationManager.AppSettings["LoginPage"]);
            loginObjects.InputLogin(ConfigurationManager.AppSettings["Login"]);
            loginObjects.InputPwd(ConfigurationManager.AppSettings["Pwd"]);
            loginObjects.LoginButton();
            goTo.NewTask(ConfigurationManager.AppSettings["NewTask"]);
            //incidentPage.TaskPageActionButton();
            incidentPage.OneMoreTask();
            incidentPage.NameOfTask();
            incidentPage.SaveTaskAndCreateOneMore();



        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
