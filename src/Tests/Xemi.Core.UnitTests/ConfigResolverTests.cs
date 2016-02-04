using Moq;
using NUnit.Framework;
using Xemi.Core.Configuration;

namespace Xemi.Core.UnitTests
{
    [TestFixture]
    public class ConfigResolverTests
    {
        [Test]
        public void ReadConfig()
        {
            var moqResolver = new Mock<IConfigResolver>();
            moqResolver.Setup(p => p.GetConfig("Test:moq")).Returns("mockvalue");

            ConfigResolver.SetResolver(moqResolver.Object);
            Assert.AreEqual("mockvalue", ConfigResolver.Current.GetConfig("Test:moq"));
        }

        [Test]
        public void ClearCacheAndReadConfig()
        {
            var moqResolver = new Mock<IConfigResolver>();
            moqResolver.Setup(p => p.GetConfig("Test:moq")).Returns("mockvalue");

            var moqResolver2 = new Mock<IConfigResolver>();
            moqResolver2.Setup(p => p.GetConfig("Test:moq")).Returns("mockvalue2");

            //set resolver
            ConfigResolver.SetResolver(moqResolver.Object);
            Assert.AreEqual("mockvalue", ConfigResolver.Current.GetConfig("Test:moq"));
            //set resolver2
            ConfigResolver.SetResolver(moqResolver2.Object);
            Assert.AreEqual("mockvalue2", ConfigResolver.Current.GetConfig("Test:moq"));
        }
    }
}