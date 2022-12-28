using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumParaBank
{
    public class SalesForce
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("John@gmail.com");



            SelectElement dropdown = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            dropdown.SelectByIndex(4);

            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");



            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            dropdown1.SelectByIndex(3);

            driver.FindElement(By.Name("UserPhone")).SendKeys("");

            SelectElement dropdown4 = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            dropdown4.SelectByValue("United Kingdom");

            driver.FindElement(By.ClassName("checkbox-ui")).Click();

            driver.FindElement(By.Name("start my free trial")).Click();



        }
    }
}
