using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Active
{
    [TestFixture]
    class Ntest
    {
        IWebDriver driver;

        [SetUp]
        public void setUp()
        {

            driver = new ChromeDriver();
            // Launch the online browser
            driver.Navigate().GoToUrl("http://www.sword-activerisk.com/customers/case-studies");
           
        }
        // exception handling 
        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }


        
        [Test] // This is a first test to check if engineering and construction tab is working
        public void shouldOpenEnCtab()
        {
            //instance of the current window
            String parentWindow = driver.CurrentWindowHandle;
            // navigate the engineering and construction tab
            driver.FindElement(By.Id("ui-id-3")).Click();
          // check if it has landed to the right page
           Assert.True(driver.Url.Contains("customers"));
        }
          


         [Test]// This is a second Test to check download pdf button for crossrail
        public void crossrailPdfTest()
        {
            String parentWindow = driver.CurrentWindowHandle;
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.Id("ui-id-3")).Click();
            //Identifying element by CSS selector. 
            driver.FindElement(By.CssSelector("a[href*='Crossrail-Case-Study.pdf']")).Click();


            // for each loop for handling parent window
            foreach (String window in driver.WindowHandles)
                {
                driver.SwitchTo().Window(window);
            }

            // check if it has opened the right page
            Assert.True(driver.Url.Contains("uploads"));
            // close the driver 
            driver.Close();
            // Back the case study page
            driver.SwitchTo().Window(parentWindow);
            // checking if it has navigated properly
            Assert.True(driver.Title.Contains("Case Studies"));
        }

        [Test]// this is a third test to navigate through learn more about croosrail case study page
        public void CrailLearnMBtn()
        {
            String parentWindow = driver.CurrentWindowHandle;
            driver.FindElement(By.Id("ui-id-3")).Click();
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.CssSelector("a[href*='crossrail-2']")).Click();
            // check if it has landed to the right page
            Assert.True(driver.Url.Contains("crossrail-2"));
            // navigate back to the  case study page
            driver.Navigate().GoToUrl("http://www.sword-activerisk.com/customers/case-studies/");

            //check if the navigation to the case study page was correct.
            driver.SwitchTo().Window(parentWindow);
            Assert.True(driver.Title.Contains("Case Studies"));

           

        }

        [Test]// This is a second Test to check download pdf button for crossrail
        public void pdfDownerTest()
        {
            String parentWindow = driver.CurrentWindowHandle;
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.Id("ui-id-3")).Click();
            //Identifying element by CSS selector. 
            driver.FindElement(By.CssSelector("a[href*='Downer-Case-Study.pdf']")).Click();


            // for each loop for handling parent window
            foreach (String window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
            }

            // check if it has opened the right page
            Assert.True(driver.Url.Contains("uploads"));
            // close the driver 
            driver.Close();
            // Back the case study page
            driver.SwitchTo().Window(parentWindow);
            // checking if it has navigated properly
            Assert.True(driver.Title.Contains("Case Studies"));
        }

        [Test]// this is a third test to navigate through learn more about croosrail case study page
        public void learnMoreDownerBtn()
        {
            String parentWindow = driver.CurrentWindowHandle;
            driver.FindElement(By.Id("ui-id-3")).Click();
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.CssSelector("a[href*='downer']")).Click();
            // check if it has landed to the right page
            Assert.True(driver.Url.Contains("downer"));
            // navigate back to the  case study page
            driver.Navigate().GoToUrl("http://www.sword-activerisk.com/customers/case-studies/");

            //check if the navigation to the case study page was correct.
            driver.SwitchTo().Window(parentWindow);
            Assert.True(driver.Title.Contains("Case Studies"));



        }
        [Test]// This is a second Test to check download pdf button for crossrail
        public void netRailPdfTest()
        {
            String parentWindow = driver.CurrentWindowHandle;
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.Id("ui-id-3")).Click();
            //Identifying element by CSS selector. 
            driver.FindElement(By.CssSelector("a[href*='Network-Rail-Case-Study.pdf']")).Click();


            // for each loop for handling parent window
            foreach (String window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
            }

            // check if it has opened the right page
            Assert.True(driver.Url.Contains("uploads"));
            // close the driver 
            driver.Close();
            // Back the case study page
            driver.SwitchTo().Window(parentWindow);
            // checking if it has navigated properly
            Assert.True(driver.Title.Contains("Case Studies"));
        }

        [Test]// this is a third test to navigate through learn more about croosrail case study page
        public void netRailLMBtn()
        {
            String parentWindow = driver.CurrentWindowHandle;
            driver.FindElement(By.Id("ui-id-3")).Click();
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.CssSelector("a[href*='network-rail-transportation']")).Click();
            // check if it has landed to the right page
            Assert.True(driver.Url.Contains("network-rail-transportation"));
            // navigate back to the  case study page
            driver.Navigate().GoToUrl("http://www.sword-activerisk.com/customers/case-studies/");

            //check if the navigation to the case study page was correct.
            driver.SwitchTo().Window(parentWindow);
            Assert.True(driver.Title.Contains("Case Studies"));

        }
        [Test]// This is a second Test to check download pdf button for crossrail
        public void slanskaPdfTest()
        {
            String parentWindow = driver.CurrentWindowHandle;
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.Id("ui-id-3")).Click();
            //Identifying element by CSS selector. 
            driver.FindElement(By.CssSelector("a[href*='Slanska-Case-Study-2pp-2012-V1.pdf']")).Click();


            // for each loop for handling parent window
            foreach (String window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
            }

            // check if it has opened the right page
            Assert.True(driver.Url.Contains("uploads"));
            // close the driver 
            driver.Close();
            // Back the case study page
            driver.SwitchTo().Window(parentWindow);
            // checking if it has navigated properly
            Assert.True(driver.Title.Contains("Case Studies"));
        }

        [Test]// this is a third test to navigate through learn more about croosrail case study page
        public void slanskaLMBtn()
        {
            String parentWindow = driver.CurrentWindowHandle;
            driver.FindElement(By.Id("ui-id-3")).Click();
            // find element with the link words crossrail case study.pdf 
            driver.FindElement(By.CssSelector("a[href*='slanska-2']")).Click();
            // check if it has landed to the right page
            Assert.True(driver.Url.Contains("slanska-2"));
            // navigate back to the  case study page
            driver.Navigate().GoToUrl("http://www.sword-activerisk.com/customers/case-studies/");

            //check if the navigation to the case study page was correct.
            driver.SwitchTo().Window(parentWindow);
            Assert.True(driver.Title.Contains("Case Studies"));

        }

    }
    }
