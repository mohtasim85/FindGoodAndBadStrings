using System.Collections.Generic;

namespace KodUppgift.Core.Interfaces.Handlers
{
    public interface IStringHandler
    {
        IEnumerable<string> FindGoodStrings(string[] stringsList);

        IEnumerable<string> FindBadStrings(string[] stringsList);
    }
}