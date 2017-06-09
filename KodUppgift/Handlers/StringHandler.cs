using System.Collections.Generic;
using System.Linq;
using KodUppgift.Core.Interfaces.Handlers;
using KodUppgift.Core.Interfaces.StringRules;

namespace KodUppgift.Handlers
{
    public class StringHandler : IStringHandler
    {
        private readonly IEnumerable<IGoodStringRule> _rules;
        public StringHandler(IEnumerable<IGoodStringRule> rules)
        {
            _rules = rules;
        }

        public IEnumerable<string> FindGoodStrings(string[] stringsList)
        {
            //TODO Check for Possibile errors and log handling
            return (from s in stringsList let res = _rules.All(rule => rule.Validate(s)) where res select s).ToList();
        }

        public IEnumerable<string> FindBadStrings(string[] stringsList)
        {
            //TODO Check for Possibile errors and log handling
            return (from s in stringsList let res = _rules.All(rule => rule.Validate(s)) where !res select s).ToList();
        }
    }
}
