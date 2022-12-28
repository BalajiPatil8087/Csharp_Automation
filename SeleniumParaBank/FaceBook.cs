using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParaBank
{
    public class FaceBook
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/signup";

            driver.FindElement(By.Name("firstname")).SendKeys("John");
            driver.FindElement(By.Name("lastname")).SendKeys("Wick");
            driver.FindElement(By.Name("reg_email__")).SendKeys("demo123@gmail.com");
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("demo123@gmail.com");
            driver.FindElement(By.Id("password_step_input")).SendKeys("Welcome123");

            
            driver.FindElement(By.Id("day")).Click();
            driver.FindElement(By.Id("month")).Click();
            driver.FindElement(By.Id("year")).Click();

            driver.FindElement(By.Id("js_16d")).Click();



            driver.FindElement(By.Id("u_0_6_GR")).Click();
            driver.FindElement(By.Id("websubmit")).Click();


        }
    }
}
