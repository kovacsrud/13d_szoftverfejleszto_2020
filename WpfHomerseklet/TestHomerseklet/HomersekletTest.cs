using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Diagnostics;
using NUnit.Framework.Interfaces;

namespace TestHomerseklet
{
    public class Tests
    {
        protected const string DriverUrl = "http://127.0.0.1:4723";
        private const string Program = @"G:\tavtanitas\kodtarak\13d_szoftverfejleszto_2020\WpfHomerseklet\WpfHomerseklet\bin\Debug\WpfHomerseklet.exe";
        protected static WindowsDriver<WindowsElement> driver;
        protected static ExtentReports extReport;
        protected static ExtentTest extTest;

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

        [OneTimeSetUp]
        public void ReportSetup()
        {
            extReport = new ExtentReports();
            
            var htmlReporter = new ExtentHtmlReporter(@"g:\13d_extrep\");
            extReport.AddSystemInfo("Homerseklet teszt","Auto test");
            extReport.AddSystemInfo("Tesztelõ:","KR");
            extReport.AttachReporter(htmlReporter);
            htmlReporter.Config.DocumentTitle = "Hõmérséklet átváltó program teszt";
            htmlReporter.Config.ReportName = "Automatizált teszt";
            htmlReporter.Config.Theme = Theme.Standard;
        }

        [Test]
        [TestCase(3,-16.11)]
        [TestCase(9, -12.78)]
        [TestCase(12, -11.11)]
        [TestCase(58, 14.44)]
        //[TestCase(58, 14.44)]
        [TestCase(85, 14.44)]
        public void TestFahrenheitToCelsius(double homerseklet,double elvart)
        {
            extTest = extReport.CreateTest("Fahrenheit to Celsius test");
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
            extTest.Log(Status.Pass, "Sikeres teszt");
        }

        [Test]
        [TestCase(14.44,58)]
        [TestCase(14.44, 58)]
        [TestCase(12.78,55)]
        [TestCase(13.33,56)]
        //[TestCase(11.11,52)]
        [TestCase(11.11, 58)]
        public void TestCelsiusToFahrenheit(double homerseklet,double elvart)
        {
            extTest = extReport.CreateTest("Celsius to Fahrenheit test");
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
            extTest.Log(Status.Pass,"Sikeres teszt");
        }

        [TearDown]
        public void CloseReport()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var message = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                ITakesScreenshot shot = (ITakesScreenshot)driver;
                var ho = TestContext.CurrentContext.Test.Arguments.GetValue(0);
                var elvart = TestContext.CurrentContext.Test.Arguments.GetValue(1);
                string fajlnev = "test_"+ho+"_"+elvart;
                
                Screenshot screenshot = shot.GetScreenshot();
                screenshot.SaveAsFile(@"G:\13d_extrep\"+fajlnev+".png",ScreenshotImageFormat.Png);
                //screenshot.SaveAsFile(fajlnev + ".png", ScreenshotImageFormat.Png);
     

                extTest.Log(Status.Fail,"Hiba!");
                extTest.Log(Status.Fail, message);
                extTest.Log(Status.Fail, stacktrace);
                extTest.Log(Status.Fail, "Kép:");
                extTest.AddScreenCaptureFromPath(fajlnev+".png");
            }

        }

        [OneTimeTearDown]
        public static void EndTest()
        {
            extReport.Flush();
        }
    }
}