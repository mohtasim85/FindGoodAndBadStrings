using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces;
using KodUppgift.Core.Interfaces.File;

namespace KodUppgift.Infrastructure
{
    public class FileManager : IFileManager
    {
        public IEnumerable<string> GetTextFromFile(IFile aFile)
        {
            //TODO Check for Possibile errors and log handling
            return aFile.GetAllText();
        }
    }
}
