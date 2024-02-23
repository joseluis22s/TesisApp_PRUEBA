using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using TesisApp.DataBase.Repositories;

namespace TesisApp.ViewModels
{
    internal class CrearNuevaCuentaViewModel : INotifyPropertyChanged
    {
        UsuarioDatabase database;


        public event PropertyChangedEventHandler PropertyChanged;

        public Command ImgBackIcon_OnTapGestureRecognizerCommand {  get; set; }

        // Inyeccion de dependencia "UsuarioDatabase". Ayuda a usar el repositorio de la BD
        // Una alternativa es crear una nueva instacnia de la clase de acceso
        // "database = new UsuarioDatabase();"
        public CrearNuevaCuentaViewModel(UsuarioDatabase usuariodatabase)
        {
            ImgBackIcon_OnTapGestureRecognizerCommand = new Command(PopAsyncPage);
            database = usuariodatabase;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public async void PopAsyncPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
