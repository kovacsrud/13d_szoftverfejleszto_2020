using NUnit.Framework;
using KRHash;

namespace HashTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Valami", "e12b6a627eaa0f35502cb406e8e0a51bc12f42a39743a0d2ea8b24c8e3fb375a30e9f9a6bb8cbffe918b5368d9707056f696ae0999270b40ee4d03b04ef3b0c6")]
        [TestCase("bármi,akármi", "846ab49aaa11ae32eafc6e4d25824fc8169ae69e889eb3d62d430249bd60dc3b9f704cabb6e55f638b05620d380aae7a6c168338589b30997d462a1acfb794ff")]
        [TestCase("Valami", "e12b6a627eaa0f35502cb406e8e0a51bc12f42a39743a0d2ea8b24c8e3fb375a30e9f9a6bb8cbffe918b5368d9707056f696ae0999270b40ee4d03b04ef3b0c6")]
        [TestCase("bármi,akármi", "846ab49aaa11ae32eafc6e4d25824fc8169ae69e889eb3d62d430249bd60dc3b9f704cabb6e55f638b05620d380aae7a6c168338589b30997d462a1acfb794ff")]
        [TestCase("Valami", "e12b6a627eaa0f35502cb406e8e0a51bc12f42a39743a0d2ea8b24c8e3fb375a30e9f9a6bb8cbffe918b5368d9707056f696ae0999270b40ee4d03b04ef3b0c6")]
        [TestCase("bármi,akármi", "846ab49aaa11ae32eafc6e4d25824fc8169ae69e889eb3d62d430249bd60dc3b9f704cabb6e55f638b05620d380aae7a6c168338589b30997d462a1acfb794ff")]
        [TestCase("Valami", "e12b6a627eaa0f35502cb406e8e0a51bc12f42a39743a0d2ea8b24c8e3fb375a30e9f9a6bb8cbffe918b5368d9707056f696ae0999270b40ee4d03b04ef3b0c6")]
        [TestCase("bármi,akármi", "846ab49aaa11ae32eafc6e4d25824fc8169ae69e889eb3d62d430249bd60dc3b9f704cabb6e55f638b05620d380aae7a6c168338589b30997d462a1acfb794ff")]
        public void SHA512Test(string szoveg,string elvart)
        {

            CreateHash hash = new CreateHash();
            var sut = hash.MakeHash(HashType.SHA512, szoveg);
            Assert.AreEqual(elvart, sut);
            
        }
    }
}