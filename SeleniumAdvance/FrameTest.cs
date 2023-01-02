using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumAdvance
{
    public class FrameTest
    {
        [Test]
      public void Demo1Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("kevin123");
            
            driver.FindElement(By.LinkText("CONTINUE")).Click();

        }
        [Test]
        public void Demo2Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
         
            string alert=  driver.SwitchTo().Alert().Text;
            Console.WriteLine(alert);
           
            driver.SwitchTo().Alert().Accept();

           

        }
    }
}
