using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces.StringRules;

namespace KodUppgift.GoodStringRules
{
    public class NotAllowedStringsRule : IGoodStringRule
    {
        readonly string[] _unAllowedStrings = { "ab", "cd", "pq", "xy" };

        public bool Validate(string word)
        {
            return !ContainStrings(word, _unAllowedStrings);
        }

        private bool ContainStrings(string source, IEnumerable<string> stringArray)
        {
            //TODO Check for Possibile errors and log handling
            return (stringArray.Any(source.Contains));
        }
    }
}
