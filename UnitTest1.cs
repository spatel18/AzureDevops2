using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TryingMsTestFramework
{
    [TestClass]
    public class UnitTest1
    {


        String test_url = "https://lambdatest.github.io/sample-todo-app/";
        String itemName = "Yey, Let's add it to list";









        [TestMethod]
        public void TestMethod1()
            

        {
            /*
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("Https://dev-evisit.on.novarihealth.net/");
            driver.FindElement(By.Id("username")).SendKeys("NovariProviderTester@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Novari123!");
            driver.FindElement(By.ClassName("primary")).Click();

            Thread.Sleep(5000);

            driver.Close();
            */

            /*

            IWebDriver driver;

            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(test_url);

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Click on First Check box
            IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
            firstCheckBox.Click();

            // Click on Second Check box
            IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
            secondCheckBox.Click();

            // Enter Item name
            IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));
            textfield.SendKeys(itemName);

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.Id("addbutton"));
            addButton.Click();
            Thread.Sleep(2000);



            // Verified Added Item name
            IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
            string getText = itemtext.Text;
            Assert.IsTrue(itemName.Contains(getText));

            Thread.Sleep(2000);
            /* Perform wait to check the output in this MSTest tutorial for Selenium */
            //System.Threading.Thread.Sleep(4000);
         

            Console.WriteLine("LT_ToDo_Test Passed");
            Thread.Sleep(2000);
            //driver.Quit();

        }
    }
}
