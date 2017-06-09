using System.Collections.Generic;

namespace KodUppgift.Core.Interfaces
{
    public interface IStringApplication
    {
        IEnumerable<string> ExtractGoodStringsFromTextFile();
        IEnumerable<string> ExtractBadStringsFromTextFile();
    }
}