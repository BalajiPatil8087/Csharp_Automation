using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo
{
    public class Go
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.goto.com/meeting";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("truste-consent-button")).Click();

            Actions action = new Actions(driver);
            try { 
            action.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch
            {

            }

            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Try Free")).Click();
           
            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("wick");
            driver.FindElement(By.Id("login__email")).SendKeys("John@gmail.com");
            SelectElement select = new SelectElement(driver.FindElement(By.Name("CompanySize")));
            select.SelectByText("10 - 99");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();
            string ree=driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(ree);
        }
    }
}
