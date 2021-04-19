using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace OsztasTest
{
    public class Tests
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string WpfProgramId = @"G:\tavtanitas\kodtarak\13d_szoftverfejleszto_2020\WpfAppiumTest\WpfAppiumTest\bin\Debug\WpfAppiumTest.exe";
        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public void Setup()
        {
            if (driver==null)
            {
                var appiumoption = new AppiumOptions();
                appiumoption.AddAdditionalCapability("app",WpfProgramId);
                appiumoption.AddAdditionalCapability("deviceName","Win10PC");
                driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl),appiumoption);
            }
        }

        [Test]
        [TestCase(12,6,2)]
        public void OsztasTest(double a,double b,double elvart)
        {
            var aErtek = driver.FindElementByAccessibilityId("textboxA");
            var bErtek = driver.FindElementByAccessibilityId("textboxB");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            aErtek.Clear();
            bErtek.Clear();
            eredmeny.Clear();
            aErtek.SendKeys(Convert.ToString(a));
            bErtek.SendKeys(Convert.ToString(b));
            driver.FindElementByAccessibilityId("buttonSzamol").Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text));
        }
    }
}