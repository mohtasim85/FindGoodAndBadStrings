using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodUppgift.Core.Interfaces;
using KodUppgift.Core.Interfaces.File;
using KodUppgift.Core.Interfaces.Handlers;
using KodUppgift.Core.Interfaces.StringRules;
using KodUppgift.GoodStringRules;
using KodUppgift.Handlers;
using KodUppgift.Infrastructure;
using SimpleInjector;

namespace KodUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisplayGoodAndBadStrings app = new DisplayGoodAndBadStrings();
            app.Run();
        }
    }

    
}
