using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces;
using KodUppgift.Core.Interfaces.File;

namespace KodUppgift.Infrastructure
{
    public class TextFile : ITextFile
    {
        public string FilePath { get; set; }

        public TextFile(string filePath)
        {
            FilePath = filePath;
        }
        public IEnumerable<string> GetAllText()
        {

            return File.ReadAllLines(FilePath, Encoding.UTF8).
                                                Where(x=>!string.IsNullOrEmpty(x)).
                                                Select(x => x.Split(' ')).
                                                SelectMany(i=>i).
                                                Where(x => !string.IsNullOrEmpty(x));
        }
    }
}
