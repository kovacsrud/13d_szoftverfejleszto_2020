using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace TestHomerseklet
{
    public class Tests
    {
        protected const string DriverUrl = "http://127.0.0.1:4723";
        private const string Program = @"G:\tavtanitas\kodtarak\13d_szoftverfejleszto_2020\WpfHomerseklet\WpfHomerseklet\bin\Debug\WpfHomerseklet.exe";
        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public void Setup()
        {
            if (driver==null)
            {
                var appiumoptions = new AppiumOptions();
                appiumoptions.AddAdditionalCapability("app",Program);
                appiumoptions.AddAdditionalCapability("device", "WinPC");
                driver = new WindowsDriver<WindowsElement>(new Uri(DriverUrl),appiumoptions);
            }      
        }

        [Test]
        [TestCase(3,-16.11)]
        [TestCase(9, -12.78)]
        [TestCase(12, -11.11)]
        [TestCase(58, 14.44)]
        [TestCase(58, 14.44)]
        public void TestFahrenheitToCelsius(double homerseklet,double elvart)
        {
            var homersekletErtek = driver.FindElementByAccessibilityId("textboxHomerseklet");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            var button = driver.FindElementByAccessibilityId("buttonSzamol");
            homersekletErtek.Clear();
            eredmeny.Clear();
            homersekletErtek.SendKeys(homerseklet.ToString());
            driver.FindElementByAccessibilityId("radioCelsius").Click();
            button.Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Debug.WriteLine(eredmeny.Text);
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text.Replace("C","")));
        }

        [Test]
        [TestCase(14.44,58)]
        [TestCase(14.44, 58)]
        [TestCase(12.78,55)]
        [TestCase(13.33,56)]
        [TestCase(11.11,52)]
        public void TestCelsiusToFahrenheit(double homerseklet,double elvart)
        {
            var homersekletErtek = driver.FindElementByAccessibilityId("textboxHomerseklet");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            var button = driver.FindElementByAccessibilityId("buttonSzamol");
            homersekletErtek.Clear();
            eredmeny.Clear();
            homersekletErtek.SendKeys(homerseklet.ToString());
            driver.FindElementByAccessibilityId("radioFahrenheit").Click();
            button.Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text.Replace("F","")),0.02);
        }
    }
}