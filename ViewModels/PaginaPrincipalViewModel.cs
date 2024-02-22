using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TesisApp.ViewModels
{
    internal class PaginaPrincipalViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PaginaPrincipalViewModel() { }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
