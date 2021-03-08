using NUnit.Framework;
using Alapmuveletek;
using System;

namespace NunitAlapmuveletekTest
{
    public class NunitAlapTest
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10,10,20)]
        [TestCase(20,30,50)]
        [TestCase(22.8,11.3,34.1)]
        public void NOsszeadasTest(double a,double b,double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            var sut = alapmuvelet.Osszeadas(a, b);

            Assert.AreEqual(elvart, sut);
        }
    }
}