using System;
using System.Configuration;
using System.Linq;
using KodUppgift.Infrastructure;
using NUnit.Framework;

namespace KodUppgift.Tests.Unit.FileTests
{
    [TestFixture()]
    public class TextFileTests
    {
        private TextFile _textFile;

        [OneTimeSetUp]
        public void Init()
        {
            string file = ConfigurationManager.AppSettings["testFile"];
            _textFile = new TextFile(file);
        }

        [Test()]
        public void Test_GetAllText_Is_Not_Empty()
        {
            Assert.IsNotEmpty(_textFile.GetAllText());
        }
                    
        [Test()]
        public void Test_GetAllText_Return_Correct_Values()
        {
            var array = new String[] { "aei", "xazego", "aeiouaeiouaeiou","ugknbfddgicrmopn" };
            Assert.AreEqual(array, _textFile.GetAllText().ToArray());
        }
    }
}