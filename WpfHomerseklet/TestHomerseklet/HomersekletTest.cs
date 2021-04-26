using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;


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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}