using System;
using NUnit.Framework;
using Xemi.Core.Configuration;
using Xemi.Core.Dependency;
using Xemi.Core.Reflection;
using Xemi.Core.UnitTests.Stubs;
using Xemi.Dependency.Autofac;

namespace Xemi.Core.UnitTests
{
    [TestFixture]
    public class EngineTests
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            ConfigResolver.SetResolver(new StubConfigResolver());
        }

        [Test]
        public void InitializeEngine()
        {
            EngineContext.Initialize();
            var engine = EngineContext.Current;
            Assert.IsNotNull(engine);
        }

        [Test]
        public void GetTypeFinder()
        {
            EngineContext.Initialize();
            var engine = EngineContext.Current;
            var typefinder = engine.Resolve<ITypeFinder>(typeof(ITypeFinder));
            Assert.IsNotNull(typefinder);
        }

        [Test]
        public void RunTask()
        {
            ConfigResolver.SetResolver(new StubConfigResolver(false));
            Assert.Throws<TestingExpectedException>(() => EngineContext.Initialize(true));
        }
    }


}