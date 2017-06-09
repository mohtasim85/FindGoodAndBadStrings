using System.Configuration;
using KodUppgift.Core.Interfaces;
using KodUppgift.Core.Interfaces.File;
using KodUppgift.Core.Interfaces.Handlers;
using KodUppgift.Core.Interfaces.StringRules;
using KodUppgift.GoodStringRules;
using KodUppgift.Handlers;
using SimpleInjector;

namespace KodUppgift.Infrastructure
{
    public class IoCContainer
    {
        private Container Container { get; set; }

        public static IoCContainer New()
        {
            return new IoCContainer();
        }

        public IoCContainer Create()
        {
            if (Container == null)
            {
                if (Container == null)
                {
                    Container = new Container();
                    RegisterTypes();
                    Container.Verify();
                }
            }

            return this;
        }

        public T GetService<T>()
        {
            return (T)Container.GetInstance(typeof(T));
        }

        private void RegisterTypes()
        {
            var filePath = ConfigurationManager.AppSettings["testFile"];
            Container.Register<ITextFile>(() => new TextFile(filePath));

            Container.RegisterCollection<IGoodStringRule>(new[]
                                                        {
                                                            typeof(VowelRule),
                                                            typeof(SimilarCharactersRule),
                                                            typeof(NotAllowedStringsRule)
                                                        });

            Container.Register<IFileManager, FileManager>();
            Container.Register<IStringHandler, StringHandler>();
            Container.Register<IStringApplication, StringApplication>();
        }
        

    }
}