using System;
using NUnit.Framework;
using Xemi.Core.Configuration;

namespace Xemi.Core.UnitTests
{
    [TestFixture]
    public class EngineTests
    {
        private class StubConfigResolver : IConfigResolver
        {
            public string GetConfig(string key)
            {
                switch (key)
                {
                    case "Xemi:DependencyManagerType":
                        {
                            return "Xemi.Dependency.Autofac.DependencyManager";
                        }
                    default:
                        {
                            return null;
                        }
                }
            }
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void InitializeEngine()
        {
            ConfigResolver.SetResolver(new StubConfigResolver());
            EngineContext.Initialize();
            var engine = EngineContext.Current;
            Assert.IsNotNull(engine);
        }
    }


}