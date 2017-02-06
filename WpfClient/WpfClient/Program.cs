using AutoMapper;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClient.ViewModels;
using WpfClient.WcfServiceReference;

namespace WpfClient
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var container = Bootstrap();
            
            RunApplication(container);
        }

        private static Container Bootstrap()
        {
            var container = new Container();

            // Register your types, for instance:
            container.Register<IWcfService>(()=>new WcfServiceClient("BasicHttpBinding_IWcfService"),Lifestyle.Singleton);
            container.Register<IMapper>(CreateAutoMapper, Lifestyle.Singleton);
            //container.Register<IUserContext, WpfUserContext>();

            // Register your windows and view models:

            //container.RegisterCollection<ViewModelBase>(,);

            container.Verify();

            return container;
        }

        private static IMapper CreateAutoMapper()
        {
            Mapper.Initialize(config => {
                config.CreateMap<FarkleModel, FarkleViewModel>().ReverseMap();
                config.CreateMap<CreateFarkleRequest, FarkleViewModel>().ForMember(x => x.Id, o => o.Ignore());
            });
            Mapper.AssertConfigurationIsValid();
            return Mapper.Configuration.CreateMapper();
        }

        private static void RunApplication(Container container)
        {
            try
            {
                var app = new App();
                var mainWindow = container.GetInstance<MainWindow>();
                app.Run(mainWindow);
            }
            catch (Exception ex)
            {
                throw;
                //Log the exception and exit
            }
        }
    }
}
