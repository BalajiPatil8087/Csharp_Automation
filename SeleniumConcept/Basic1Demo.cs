using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenimConcept;
public class Basic1Demo
{
    static void Main1(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Url = "https://github.com/login";//set//navigate to url
        string title=driver.Title;
        Console.WriteLine(title);

        Console.WriteLine(driver.Url);//get//get the current url

        Console.WriteLine(driver.PageSource); //get source code of page
    }
}
