using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces;
using KodUppgift.Infrastructure;

namespace KodUppgift
{
    public class DisplayGoodAndBadStrings : IDisplayGoodAndBadStrings
    {
        private IoCContainer _container;
        private IStringApplication _app;

        public void Run()
        {
            try
            {
                Initialize();
                DisplayGoodStrings();
                DisplayBadStrings();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                Console.ReadKey();
            }
        }

        private void Initialize()
        {
            _container = IoCContainer.New().Create();
            _app = _container.GetService<IStringApplication>();
        }

        private void DisplayGoodStrings()
        {
            Console.WriteLine("Good Strings:");
            _app.ExtractGoodStringsFromTextFile().ToList().ForEach(Console.WriteLine);
        }

        private void DisplayBadStrings()
        {
            Console.WriteLine("Bad Strings:");
            _app.ExtractBadStringsFromTextFile().ToList().ForEach(Console.WriteLine);
        }
    }
}