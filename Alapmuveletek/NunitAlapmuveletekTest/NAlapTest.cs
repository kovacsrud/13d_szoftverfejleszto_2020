using NUnit.Framework;
using Alapmuveletek;
using System;
using System.Collections.Generic;
using System.IO;

namespace NunitAlapmuveletekTest
{
    public class NunitAlapTest
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase(10,10,20)]
        //[TestCase(20,30,50)]
        //[TestCase(22.8,11.3,34.1)]
        [TestCaseSource("GetOsszeadasAdatok")]
        public void NOsszeadasTest(double a,double b,double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            var sut = alapmuvelet.Osszeadas(a, b);

            Assert.AreEqual(elvart, sut);
        }

        [Test]
        [TestCaseSource("GetOsztasAdatok")]
        public void NOsztasTest(double a,double b,double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Osztas(a, b);

            Assert.AreEqual(elvart, sut,0.000001);

        }

        public static IEnumerable<double[]> GetOsszeadasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osszeadas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var e = sorok[i].Split(';');
                double a = Convert.ToDouble(e[0]);
                double b = Convert.ToDouble(e[1]);
                double elvart = Convert.ToDouble(e[2]);

                yield return new[] {a,b,elvart };
            }
        }

        public static IEnumerable<double[]> GetOsztasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osztas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var e = sorok[i].Split(';');
                double a = Convert.ToDouble(e[0]);
                double b = Convert.ToDouble(e[1]);
                double elvart = Convert.ToDouble(e[2]);

                yield return new[] { a, b, elvart };

            }
        }
    }
}