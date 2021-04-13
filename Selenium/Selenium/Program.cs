using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://tanlaktanya.taszi.hu";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.LinkText("Belépés")).Click();
            driver.FindElement(By.Id("username")).SendKeys("seleniumtest");
            driver.FindElement(By.Id("password")).SendKeys("a1234567"+Keys.Enter);

            driver.FindElement(By.LinkText("Programozás")).Click();
            driver.FindElement(By.LinkText("Szoftverfejlesztő (14d13b)")).Click();

            //IList<IWebElement> elemek = driver.FindElements(By.XPath("/html/body/div[2]/div/div[4]/div/div/div[1]/div/div/div/ul/li[2]/div[3]"));
            IList<IWebElement> elemek = driver.FindElements(By.XPath("//*[@id=\"section-0\"]"));
            ////*[@id="section-1"]
            Console.WriteLine($"Elemek száma:{elemek.Count}");

            for (int i = 0; i < elemek.Count; i++)
            {
                Console.WriteLine(elemek[i].Text);
            }

            Thread.Sleep(5000);

            //driver.Close();

            Console.ReadKey();
        }
    }
}
