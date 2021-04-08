using NUnit.Framework;
using KRHash;

namespace DllTestNunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("4dd8fbfbea57fa9c716a4cfd1fbca657851f227018dc44419cb962c3313c501fb3c65f4c186ebe01f3a7019b2b050412593c5ee18457d52b70e2dd8b546c8a80","valami")]
        [TestCase("4dd8fbfbea57fa9c716a4cfd1fbca657851f227018dc44419cb962c3313c501fb3c65f4c186ebe01f3a7019b2b050412593c5ee18457d52b70e2dd8b546c8a80", "valami")]
        [TestCase("4dd8fbfbea57fa9c716a4cfd1fbca657851f227018dc44419cb962c3313c501fb3c65f4c186ebe01f3a7019b2b050412593c5ee18457d52b70e2dd8b546c8a80", "valami")]
        [TestCase("4dd8fbfbea57fa9c716a4cfd1fbca657851f227018dc44419cb962c3313c501fb3c65f4c186ebe01f3a7019b2b050412593c5ee18457d52b70e2dd8b546c8a80", "valami")]
        [TestCase("4dd8fbfbea57fa9c716a4cfd1fbca657851f227018dc44419cb962c3313c501fb3c65f4c186ebe01f3a7019b2b050412593c5ee18457d52b70e2dd8b546c8a80", "valami")]
        public void TestSHA512(string elvart,string szoveg)
        {
            //Arrange
            CreateHash hash = new CreateHash();
            //Act
            var sut = hash.MakeHash(HashType.SHA512, szoveg);

            //Assert
            Assert.AreEqual(elvart, sut);
            
        }

        [Test]
        [TestCase("249d6c99eff6d0ef6c470e4254629323","valami")]
        [TestCase("249d6c99eff6d0ef6c470e4254629323", "valami")]
        [TestCase("249d6c99eff6d0ef6c470e4254629323", "valami")]
        [TestCase("249d6c99eff6d0ef6c470e4254629323", "valami")]
        [TestCase("249d6c99eff6d0ef6c470e4254629323", "valami")]
        [TestCase("249d6c99eff6d0ef6c470e4254629323", "valami")]
        public void TestMd5(string elvart,string szoveg)
        {
            CreateHash hash = new CreateHash();
            var sut = hash.MakeHash(HashType.MD5, szoveg);
            Assert.AreEqual(elvart, sut);
        }
    }
}