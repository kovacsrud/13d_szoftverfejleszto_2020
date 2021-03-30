using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeluletTeszt
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
            Thread.Sleep(2000);
            driver.FindElement(By.Id("username")).SendKeys("seleniumtest");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys("a1234567"+Keys.Enter);
            driver.FindElement(By.LinkText("Programozás")).Click();
            driver.FindElement(By.LinkText("Szoftverfejlesztő (14d13b)")).Click();

            ////*[@id="section-1"]
            IList<IWebElement> elemek = driver.FindElements(By.XPath("/html/body/div[2]/div/div[4]/div/div/div[2]/div/div[1]/div[2]/ul"));

            Console.WriteLine($"Elemek száma:{elemek.Count}");

            foreach (var i in elemek)
            {
                Console.WriteLine(i.Text);
            }


            Thread.Sleep(6000);

            //driver.Close();

            Console.ReadKey();
        }
    }
}
