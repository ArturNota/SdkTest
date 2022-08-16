using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Configuration;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium.Support.Extensions;

namespace NotaTest.IMS.Login
{
    class LoginObjects
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [FindsBy(How = How.XPath, Using = "//*[@id='login - popup']/form/div[1]/div[1]/input")]
        public IWebElement LoginInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "input[name='USER_PASSWORD']")]
        public IWebElement PwdInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Войти']")]
        public IWebElement Loginbutton { get; set; }



        public LoginObjects(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));



        }

        public void InputLogin(string Login)
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(LoginInput)).Click();
            //wait.Until(ExpectedConditions.ElementToBeClickable(LoginInput)).SendKeys(Login);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='admin';", element);
        }

        public void InputPwd(string Pwd)
        {
            

            
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Wa}597g9HH9e\"}Y;99';", element);
        }


        public void LoginButton()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(Loginbutton)).Click();
            //$('input[value="Войти"]').click();
            IWebElement element = driver.FindElement(By.CssSelector("input[value='Войти']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].click();", element);
        }


        public void InputLoginSogl()
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='devnull@soglr.ru';", element);
        }

        public void InputPwdSogl()
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Abt8v@~Z0n31!';", element);
        }


        public void InputLoginOper()
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='oper';", element);
        }

        public void InputPwdOper()
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Abt8v@~Z0n2!';", element);
        }

        public void InputLoginOperReg()
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='devnullsogl';", element);
        }

        public void InputPwdOperReg()
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Abt8v@~Z0n3!';", element);
        }

        public void InputLoginSois()
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='devnull@sispol.ru';", element);
        }

        public void InputPwdSois()
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Abt8v@~Z0n6!';", element);
        }
















    }
}
