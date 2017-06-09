using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces.StringRules;

namespace KodUppgift.GoodStringRules
{
    public class SimilarCharactersRule : IGoodStringRule
    {
        public bool Validate(string word)
        {
            return HasSimilarCharactersCount(word, 2);
        }

        private bool HasSimilarCharactersCount(string source, int sequenceLength)
        {
            //TODO Check for Possibile errors and log handling
            return Regex.IsMatch(source, "([a-zA-Z])\\1{" + (sequenceLength - 1) + "}");
        }
    }
}
