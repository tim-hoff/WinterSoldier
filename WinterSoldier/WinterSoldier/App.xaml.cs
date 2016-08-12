using Akavache;
using Microsoft.Practices.Unity;
using Prism.Unity;
using WinterSoldier.Views;

namespace WinterSoldier
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            BlobCache.ApplicationName = "WinterSoldier";

            BlobCache.LocalMachine.InsertObject("this_key", 1);

        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterInstance(BlobCache.LocalMachine);
        }
    }
}
