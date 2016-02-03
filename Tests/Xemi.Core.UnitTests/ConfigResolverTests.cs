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
    }
}