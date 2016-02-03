using System;
using NUnit.Framework;
using Xemi.Core.Configuration;
using Xemi.Core.Dependency;
using Xemi.Core.UnitTests.Stubs;
using Xemi.Dependency.Autofac;

namespace Xemi.Core.UnitTests
{
    [TestFixture]
    public class EngineTests
    {
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