using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAdvance
{
    public class Royal
    {
        [Test]
        public void SignUpTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.royalcaribbean.com/account/create";
           

            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("John");

            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("Wick");

            driver.FindElement(By.XPath("//span[text()='Month']")).Click();

            
            driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();

            driver.FindElement(By.XPath("//span[text()='Day']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='4']")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("1990");
          

            driver.FindElement(By.XPath("//span[text()='Country/Region of residence']")).Click();
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()='India']"))).Perform();
            driver.FindElement(By.XPath("//span[normalize-space()='India']")).Click();

            Actions actions1 = new Actions(driver);
            driver.FindElement(By.XPath("//input[@data-placeholder='Email address']")).Click();
            actions1.MoveToElement(driver.FindElement(By.XPath("//input[@data-placeholder='Email address']"))).Perform();
            driver.FindElement(By.XPath("//input[@data-placeholder='Email address']")).SendKeys("John12@gmail.com");


            driver.FindElement(By.XPath("//input[@data-placeholder='Create new password']")).SendKeys("Sagar@8087");

            driver.FindElement(By.XPath("//span[text()='Select one security question']")).Click();
            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()=\"What was your first car's make or model?\"]")));
            driver.FindElement(By.XPath("//span[normalize-space()=\"What was your first car's make or model?\"]")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Answer']")).SendKeys("yes");

            driver.FindElement(By.XPath("(//span[@class=\"mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin\"])[1]")).Click();


            driver.FindElement(By.XPath("(//span[@class=\"mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin\"])[2]")).Click();

            driver.FindElement(By.XPath("//button[normalize-space()=\"Done\"]")).Click();
        }
    }
}
