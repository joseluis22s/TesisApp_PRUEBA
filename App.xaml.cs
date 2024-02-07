using TesisApp.Views;

namespace TesisApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IniciarSesionPage());
        }
    }
}
