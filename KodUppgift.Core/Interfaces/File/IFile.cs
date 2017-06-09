using System.Collections.Generic;

namespace KodUppgift.Core.Interfaces.File
{
    public interface IFile
    {
        IEnumerable<string> GetAllText();
    }
}
