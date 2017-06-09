using KodUppgift.GoodStringRules;
using NUnit.Framework;

namespace KodUppgift.Tests.Unit.GoodStringRules
{
    [TestFixture()]
    public class SimilarCharactersRuleTests
    {
        [Test()]
        public void Test_Validation_True()
        {
            SimilarCharactersRule rule = new SimilarCharactersRule();

            Assert.True(rule.Validate("aa"));
            Assert.True(rule.Validate("aiodbb"));
            Assert.True(rule.Validate("cvbnyyjj"));
        }

        [Test()]
        public void Test_Validation_False()
        {
            SimilarCharactersRule rule = new SimilarCharactersRule();

            Assert.False(rule.Validate("ab"));
            Assert.False(rule.Validate("aikjhsfudsyfu"));
            Assert.False(rule.Validate("beib"));
        }
    }
}