using System.Collections.Generic;

namespace KodUppgift.Core.Interfaces.File
{
    public interface IFileManager
    {
        IEnumerable<string> GetTextFromFile(IFile aFile);
    }
}
