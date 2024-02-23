using System.ComponentModel;
using System.Runtime.CompilerServices;
using TesisApp.Views;
using CommunityToolkit.Maui.Alerts;


namespace TesisApp.ViewModels
{
    internal class IniciarSesionViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _usuario;
        private string _contrasena;

        public string Usuario
        {
            get
            {
                if (string.IsNullOrEmpty(_usuario))
                {
                    return _usuario = string.Empty;
                }
                return _usuario;
            }
            set => _usuario = value;
        }
        public string Contrasena
        {
            get
            {
                if (string.IsNullOrEmpty(_contrasena))
                {
                    return _contrasena = string.Empty;
                }
                return _contrasena;
            }
            set => _contrasena = value;
            
        }
        public Command PushAsyncPaginaPrincipalPageCommand { get ; set;}
        public Command PushAsyncpCrearNuevaCuentaPageCommand {  get ; set;}
        public IniciarSesionViewModel()
        {
            PushAsyncPaginaPrincipalPageCommand = new Command(PushAsyncpPaginaPrincipalPage);
            PushAsyncpCrearNuevaCuentaPageCommand = new Command(PushAsyncpCrearNuevaCuentaPage);
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));

        public async void PushAsyncpPaginaPrincipalPage()
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new PaginaPrincipalPage());
            int respuesta = VerificarInicioSesion(Usuario, Contrasena);
            if (respuesta == 1)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ConfiguracionPage());
                return;
            }
            if (respuesta == 2)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PaginaPrincipalPage());
                return;
            }
            if (respuesta == 0)
            {
                await Toast.Make("¡Debe llenar todos los campos!").Show();
                return;
            }
            if (respuesta == -1)
            {
                await Toast.Make("Usuario o contraseña incorrectas").Show();
                return;
            }
        }
        public int VerificarInicioSesion(string usuario, string contrasena)
        {
            if (usuario.Equals("Admin") && string.IsNullOrEmpty(contrasena))
            {
                return 1;
            }
            else if (usuario.Equals("Usuario") && contrasena.Equals("1"))
            {
                return 2;
            }
            else if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contrasena))
            {
                return 0;
            }
            return -1;
        }

        public async void PushAsyncpCrearNuevaCuentaPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new CrearNuevaCuentaPage());
        }
    }
}
