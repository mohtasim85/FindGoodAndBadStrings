using System;
using System.Linq;
using KodUppgift.Core.Interfaces;
using KodUppgift.Infrastructure;
using NUnit.Framework;


namespace KodUppgift.Tests.Integration
{
    [TestFixture()]
    public class StringApplicationTests
    {

        private IoCContainer _container;
        private IStringApplication _app;

        [OneTimeSetUp()]
        public void Initialize()
        {
            _container = IoCContainer.New().Create();
            _app = _container.GetService<IStringApplication>();
        }

        [Test()]
        public void ExtractGoodStringsFromTextFileTest()
        {
            var array = new [] { "ugknbfddgicrmopn" };
            Assert.AreEqual(array, _app.ExtractGoodStringsFromTextFile().ToArray());
        }

        [Test()]
        public void ExtractBadsStringsFromTextFileTest()
        {
            var array = new String[] { "notgd", "aei" };
            Assert.AreEqual(array, _app.ExtractBadStringsFromTextFile().ToArray());
        }
    }
}