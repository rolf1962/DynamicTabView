namespace ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class TabPageUserControlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
