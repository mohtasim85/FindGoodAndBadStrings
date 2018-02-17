using KodUppgift.GoodStringRules;
using NUnit.Framework;

namespace KodUppgift.Tests.Unit.GoodStringRules
{
    [TestFixture()]
    public class NotAllowedStringsRuleTests
    {
        [Test()]
        public void Test_Validation_True()
        {
            NotAllowedStringsRule rule = new NotAllowedStringsRule();

            Assert.True(rule.Validate("assdf"));
            Assert.True(rule.Validate("cfg"));
            Assert.True(rule.Validate("p"));
            Assert.True(rule.Validate("xsfads"));
            
            Assert.True(rule.Validate("asdf"));
        }

        [Test()]
        public void Test_Validation_False()
        {
            NotAllowedStringsRule rule = new NotAllowedStringsRule();

            Assert.False(rule.Validate("ab"));
            Assert.False(rule.Validate("cd"));
            Assert.False(rule.Validate("sdhfpq"));
            Assert.False(rule.Validate("xyxyxyx"));
        }
    }
}