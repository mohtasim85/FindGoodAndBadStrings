using System.Collections.Generic;
using System.Linq;
using KodUppgift.Core.Interfaces;
using KodUppgift.Core.Interfaces.File;
using KodUppgift.Core.Interfaces.Handlers;
using KodUppgift.Handlers;

namespace KodUppgift
{
    public class StringApplication : IStringApplication
    {
        private ITextFile File { get; }
        private IFileManager FileManager { get; }
        private IStringHandler StringHandler { get; }

        public StringApplication(ITextFile file, IFileManager fileManager, IStringHandler handler)
        {
            File = file;
            FileManager = fileManager;
            StringHandler = handler;
        }

        public IEnumerable<string> ExtractGoodStringsFromTextFile()
        {
            return StringHandler.FindGoodStrings(GetTextFromTextFile());
        }

        public IEnumerable<string> ExtractBadStringsFromTextFile()
        {
            return StringHandler.FindBadStrings(GetTextFromTextFile());
        }

        private string[] GetTextFromTextFile()
        {
            return FileManager.GetTextFromFile(File).ToArray();
        }


    }
}
