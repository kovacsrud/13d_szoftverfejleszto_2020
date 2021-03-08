using Alapmuveletek;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlapmuveletekTest
{
    [TestClass]
    public class AlapTest
    {
        [TestMethod]
        public void OsszeadasTest()
        {
            //Arrange, Act, Assert
            //Arrange - előkészületek, pl. példányosítás
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            //Act - a tesztelendő metódus meghívása
            //valamilyen tevékenység
            var sut = alapmuvelet.Osszeadas(10, 10);

            //Assert - A kapott érték összehasonlítása
            //egy elvárt értékkel
            Assert.AreEqual(20, sut);
           

        }

        [TestMethod]
        public void KivonasTest()
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            var sut = alapmuvelet.Kivonas(20, 10);

            Assert.AreEqual(10, sut);
        }

        [TestMethod]
        public void SzorzasTest()
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            var sut = alapmuvelet.Szorzas(5, 5);

            Assert.AreEqual(25, sut);

        }

        [TestMethod]
        public void OsztasTest()
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            var sut = alapmuvelet.Osztas(10, 10);

            Assert.AreEqual(1, sut);
        }
    }
}
