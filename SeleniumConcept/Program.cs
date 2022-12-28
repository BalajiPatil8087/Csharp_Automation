using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenimConcept;
public class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Url = "https://github.com/login";//set//navigate to url

        driver.FindElement(By.Id("login_field")).SendKeys("BalajiPatil8087");
        driver.FindElement(By.Name("password")).SendKeys("Sagar@808721");
        driver.FindElement(By.Name("commit")).Click();


    }
}
