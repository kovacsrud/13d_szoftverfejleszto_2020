using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace Tests
{
    public class Tests
    {
        protected const string WinDriver = "http://127.0.0.1:4723";
        //private const string ProgramHely = @"D:\rud\c#_projects\WpfAngolszász\WpfAngolszász\bin\Debug\WpfAngolszász.exe";
        private const string ProgramHely = @"D:\angolszasz\WpfAngolszasz.exe";
        protected static WindowsDriver<WindowsElement> windriver;




        [OneTimeSetUp]
        public void Setup()
        {
            if (windriver==null)
            {
                var appiumopts = new AppiumOptions();
                appiumopts.AddAdditionalCapability("app",ProgramHely);
                appiumopts.AddAdditionalCapability("device", "WinPC");
                windriver = new WindowsDriver<WindowsElement>(new Uri(WinDriver),appiumopts);
            }
        }

        [Test]
        [TestCase(1,40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        [TestCase(1, 40)]
        public void TestMeter2Inch(double meter, double elvart)
        {
            //Arrange,Act,Assert
            var meterAdat = windriver.FindElementByAccessibilityId("textboxM");
            var eredmeny = windriver.FindElementByAccessibilityId("textblockEredmeny");
            var gomb = windriver.FindElementByAccessibilityId("buttonSzamol");

            meterAdat.Clear();
            eredmeny.Clear();

            meterAdat.SendKeys(meter.ToString());
            windriver.FindElementByAccessibilityId("radioMtoInch").Click();
            gomb.Click();
            eredmeny = windriver.FindElementByAccessibilityId("textblockEredmeny");

            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.002);


            

        }
    }
}