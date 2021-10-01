// using System;

// namespace Frist_Test
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace Frist_Test
{

public class Program
{
static void Main(string[] args)
{
    abc();
}

private static void abc()
{    
    FirefoxBinary binary = new FirefoxBinary();
    FirefoxOptions options = new FirefoxOptions();//optional
    options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
    IWebDriver driver = new FirefoxDriver(options);

    driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
    driver.FindElement(By.Name("txtUsername")).SendKeys("Admin");
    driver.FindElement(By.Name("txtPassword")).SendKeys("admin123");
    driver.FindElement(By.Name("Submit")).Click();
    Thread.Sleep(2000);
    driver.Quit();
}

}
}
