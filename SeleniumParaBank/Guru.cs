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
    public class Guru
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";

            driver.FindElement(By.Name("firstName")).SendKeys("Povan");
            driver.FindElement(By.Name("lastName")).SendKeys("coolkarni");
            driver.FindElement(By.Name("phone")).SendKeys("9964326107");
            driver.FindElement(By.Id("userName")).SendKeys("Po@gmail.com");
            driver.FindElement(By.Name("address1")).SendKeys("NavipethPune");
            driver.FindElement(By.Name("city")).SendKeys("pune");
            driver.FindElement(By.Name("state")).SendKeys("Maharatra");
            driver.FindElement(By.Name("postalCode")).SendKeys("591120");

            SelectElement selectcountry = new SelectElement(driver.FindElement(By.Name("country")));
            selectcountry.SelectByText("INDIA");

            driver.FindElement(By.Name("submit")).Click();



        }
    }
}
