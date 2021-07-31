using Prism.Ioc;
using Prism.Modularity;
using PrismMain.Views;
using System.Windows;

namespace PrismMain
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog.AddModule<MailModule>();
            //moduleCatalog.AddModule<ContactsModule>();
        }
    }
}
