namespace DynamicTabView.ViewModels
{
    using DynamicTabView.DataAccess;
    using DynamicTabView.Model;
    using System;
    using System.Collections.ObjectModel;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class ContactsUserControlViewModel : TabPageUserControlViewModel
    {
        private Contact _currentContact;

        public ContactsUserControlViewModel()
        {
            Contacts = new ObservableCollection<Contact>(ContactsContext.Instance.Contacts);
        }

        public ObservableCollection<Contact> Contacts { get; }

        public Contact CurrentContact
        {
            get { return _currentContact; }
            set
            {
                if (_currentContact != value)
                {
                    _currentContact = value;
                    NotifyPropertyChanged();
                    OnCurrentContactChanged(EventArgs.Empty);
                }
            }
        }

        public event EventHandler CurrentContactChanged;
        private void OnCurrentContactChanged(EventArgs e)
        {
            CurrentContactChanged?.Invoke(this, e);
        }
    }
}