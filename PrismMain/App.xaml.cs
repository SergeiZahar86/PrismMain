using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using PrismMain.Module;
using PrismMain.Views;
using System.Windows;

namespace PrismMain
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TabView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<MainModule>();
            //moduleCatalog.AddModule<MailModule>();
            //moduleCatalog.AddModule<ContactsModule>();
        }
    }
}
