using DynamicTabView.DataAccess;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DynamicTabView.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected ContactsContext ContactsContext { get { return ContactsContext.Instance; } }
    }
}
