using KodUppgift.GoodStringRules;
using NUnit.Framework;

namespace KodUppgift.Tests.Unit.GoodStringRules
{
    [TestFixture()]
    public class VowelRuleTests
    {

        [Test()]
        public void Test_Validation_True()
        {
            VowelRule rule = new VowelRule();

            Assert.True(rule.Validate("aei"));
            Assert.True(rule.Validate("aaai"));
            Assert.True(rule.Validate("afioo"));
        }

        [Test()]
        public void Test_Validation_False()
        {
            VowelRule rule = new VowelRule();

            Assert.False(rule.Validate("abb"));
            Assert.False(rule.Validate("a"));
            Assert.False(rule.Validate("beibb"));
        }
    }
}