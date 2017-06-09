using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces.StringRules;

namespace KodUppgift.GoodStringRules
{
    public class VowelRule : IGoodStringRule
    {
        public bool Validate(string word)
        {
            return GetVowelCount(word) >= 3;
        }

        private int GetVowelCount(string word)
        {
            //TODO Check for Possibile errors and log handling
            return System.Text.RegularExpressions.Regex.Matches(word.ToLower(), "[aeoiu]").Count;
        }
    }
}
