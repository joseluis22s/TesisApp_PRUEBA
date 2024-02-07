using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TesisApp.ViewModels
{
    // - V1
    // Implmemtación de la interfaz "INotifyPropertyChanged" que proporciona a
    // una clase la capacidad de generar el evento PropertyChanged cada vez que
    // cambia una de sus propiedades.
    internal class IniciarSesionViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _usuario;
        private string _contrasena;
        public Command PushAsyncPaginaPrincipalCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new Views.PaginaPrincipalPage());
                });
            }
        }
        public string Usuario
        {
            get => _usuario;
            set { _usuario = value; }
        }
        public string Contrasena
        {
            get => _contrasena;
            set { _contrasena = value; }
        }
        public IniciarSesionViewModel()
        {
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));




        //// - V1
        ////El mecanismo de enlace de datos de .NET MAUI adjunta un controlador a
        ////este evento "PropertyChanged" para que reciba una notificación cuando
        ////cambie una propiedad y mantenga el destino actualizado con el nuevo valor.
        //public event PropertyChangedEventHandler PropertyChanged;

        //// - V1
        ////Establecer los atributos de las propiedades

        //// - V1
        ////Atributos:
        //private string _usuario;
        //private string _contrasena;

        //// -V3
        //// Interfaz "INavigationService"
        //public INavigation Navigation { get; set; }



        //// -V3
        //// Comandos: Interfaz de comandos "ICommand" proporciona un enfoque
        //// alternativo para implementar comandos que se adapta mucho mejor
        //// a la arquitectura MVVM. Para eventos clicked o tappep.
        //// Los comandos son métodos que se ejecutan en respuesta a una actividad
        //// específica en la vista. SET es private por que nadie accede a él.
        //public Command PushAsyncPaginaPrincipalCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            await Application.Current.MainPage.Navigation.PushAsync(new Views.PaginaPrincipalPage());
        //        });
        //    }
        //}


        //// - V1
        ////Propiedades:
        //public string Usuario
        //{
        //    get => _usuario;
        //    set { _usuario = value;}
        //}
        //public string Contrasena
        //{
        //    get => _contrasena;
        //    set { _contrasena = value;}
        //}
        //// -V2
        ////Constructor de la clase
        //public IniciarSesionViewModel(/*INavigation navigation*/)
        //{
        //    //this.Navigation = navigation;
        //    //this.PushAsyncPaginaPrincipalCommand = new Command(async () => await PushAsyncPaginaPrincipal());
        //}

        //// - V1
        ////Método "OnPropertyChanged" controla la generación del evento a la vez
        ////que determina automáticamente el nombre de origen de la propiedad: DateTime.
        ////      public void OnPropertyChanged([CallerMemberName] string name = "") =>
        ////      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //public void OnPropertyChanged([CallerMemberName] string name = "") =>
        //    PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));

        //// - V4
        ////Task
        ////public async Task PushAsyncPaginaPrincipal()
        ////{
        ////    await Navigation.PushAsync(new Views.PaginaPrincipalPage());
        ////}

    }
}
