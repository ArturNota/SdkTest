using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace NotaTest.IMS.PageObjects
{
    class IncidentPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [FindsBy(How = How.CssSelector, Using = "a[title='Добавить инцидент']")]
        public IWebElement AddIncidentButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='UF_SERIAL_NUMBER']")]
        public IWebElement NumberOfIncident { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-name='UF_LEVEL']")]
        public IWebElement Levellist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='popup - window - content - popup - window - mqwvsnr3']/div/div[4]")]
        public IWebElement Priority { get; set; }

        public IncidentPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));

        }
        
        public void addIncidentButton()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(AddIncidentButton)).Click();
            driver.Navigate().GoToUrl("https://b24ims.notamedia.ru/incident/details/0/?category_id=0");
        }

        public void NumberOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("input[name='UF_SERIAL_NUMBER']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='4532534';", element);
        }

        public void DescriptionOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("textarea[name='TITLE']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='1342235 TestName';", element);
        }

        public void ShortDescriptionOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("input[name='UF_SHORT_NAME']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='тест';", element);
        }

        public void AdressOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector(".uf-address-search-input"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Москва';", element);
        }

        public void LevelOfIncidentInput()
        {
            IWebElement element = driver.FindElement(By.CssSelector(".main-ui-control.main-ui-select[data-name='UF_LEVEL']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            
        }

        public void LevelOfIncidentInputValue()
        {

            IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(1)"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();

        }

        public void PriorityOfIncident()
        {
            IWebElement element = driver.FindElement(By.CssSelector("#UF_IMPORTANCE_control_"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();

        }

        public void PriorityOfIncidentInput()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Средний']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            

            
        }

        public void AdressOfIncidentInput2()
        {
            
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("textarea[name='UF_DESCRIPTION']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Тест Тест';", element);
        }

        public void TimeOfEnd()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();\

            IWebElement element = driver.FindElement(By.CssSelector("input[value='26.05.2022']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element);
            action.Perform();

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='20.07.2023';", element);
        }
        public void CreateTask()
        {
            IWebElement element = driver.FindElement(By.CssSelector(".crm-entity-stream-section-new-action[data-item-id='task']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();



        }

        public void NameOfTask()
        {
            System.Threading.Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));


            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[data-bx-id='task-edit-title']"))).SendKeys("TEST");
            

        }

        public void DescriptionOfTask()
        {
            System.Threading.Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("bx-editor-iframe")));


            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("body"))).SendKeys("TEST");
            driver.SwitchTo().ParentFrame();


        }

        public void StatusOfTask()
        {
            
            driver.FindElement(By.CssSelector("#divbitrix_tasks_task_default_1"));
            driver.SwitchTo().Frame(1);


            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("body"))).SendKeys("TEST 2");
            driver.SwitchTo().ParentFrame();


        }

        public void CacncelCreateTask()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='ui-btn ui-btn-link']"))).Click();
            //IWebElement element = driver.FindElement(By.CssSelector("input[data-bx-id='task-edit-cancel-button']"));
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }
        public void SaveTask()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));


            
            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui-btn ui-btn-success']"))).Click();
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void SaveTaskAndCreateOneMore()
        {
            //driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));


            String javascript = "$(\"button[value = '1']\").click()";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(javascript);





        }
        public void SaveTaskWithOutFrame()
        {
            //driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));



            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui-btn ui-btn-success']"))).Click();
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void TaskPageActionButton()
        {
            



            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tbody/tr[1]/td[2]/span[1]/a[1]"))).Click();
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void CreateTaskInActionBar()
        {




            
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Добавить подзадачу')]"))).Click();
            



        }

        public void ClickOnTask()
        {




            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            driver.Navigate().GoToUrl("https://b24ims.notamedia.ru/company/personal/user/1/tasks/task/view/1510/");
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void OneMoreTask()
        {



            
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='task-more-button ui-btn ui-btn-light-border ui-btn-dropdown']"))).Click();
            System.Threading.Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@title='Добавить подзадачу']//span[2]"))).Click();
            



        }

        public void ClickOnEndTask()
        {




            
            IWebElement element = driver.FindElement(By.CssSelector("//tbody/tr[1]/td[2]/span[1]/a[1]"));
            
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();



        }









        public void Cancel()
        {

            IWebElement element = driver.FindElement(By.CssSelector("a[title='[Esc]']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //TODO Wait to present alert

        }

        public void SaveButton()
        {

            IWebElement element = driver.FindElement(By.CssSelector("button[title='[Ctrl+Enter]']"));
            element.SendKeys(Keys.Control + Keys.Enter);

        }
    }
}
