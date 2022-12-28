using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParaBank
{
    public class ParaBank
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Sachin");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("Patil");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("Navi peth pune");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("Pune");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharastra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("415001");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("9964326107");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("12345");

            driver.FindElement(By.Id("customer.username")).SendKeys("Sagar");
            driver.FindElement(By.Id("customer.password")).SendKeys("12345");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("12345");

            driver.FindElement(By.CssSelector("input[value='Register']")).Click();

                
        }
    }
}
