using System.Collections.Generic;
using KodUppgift.Core.Interfaces.StringRules;
using KodUppgift.Handlers;
using Moq;
using NUnit.Framework;

namespace KodUppgift.Tests.Unit.HandlerTests
{
    [TestFixture()]
    public class StringHandlerTests
    {
        [Test()]
        public void FindGoodStringsTest()
        {
            //TODO: Use AutoFixture
            Mock<IEnumerable<IGoodStringRule>> rulesMock = new Mock<IEnumerable<IGoodStringRule>>();

            rulesMock.Setup(rules => rules.GetEnumerator().Current.Validate(""))
                  .Returns(true).Verifiable();

            var handler = new StringHandler(rulesMock.Object);

            var array = new[] { "ab", "cd" };

            Assert.AreEqual(array, handler.FindGoodStrings(array));
        }

        [Test()]
        public void FindBadStringsTest()
        {
            //TODO: Use AutoFixture
            Mock<IEnumerable<IGoodStringRule>> rulesMock = new Mock<IEnumerable<IGoodStringRule>>();

            rulesMock.Setup(rules => rules.GetEnumerator().Current.Validate(""))
                  .Returns(false).Verifiable();

            var handler = new StringHandler(rulesMock.Object);

            var array = new[] { "ab", "cd" };

            Assert.AreEqual(new string[] {}, handler.FindBadStrings(array));
        }
    }
}