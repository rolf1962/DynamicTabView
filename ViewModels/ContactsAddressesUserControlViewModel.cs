using DynamicTabView.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DynamicTabView.ViewModels
{
    public class ContactsAddressesUserControlViewModel : ViewModelBase
    {
        private ContactAddress _currentContactAddress;

        public ContactsAddressesUserControlViewModel()
        {
            ContactAddresses = new ObservableCollection<ContactAddress>();
        }

        public ObservableCollection<ContactAddress> ContactAddresses { get; }

        public ContactAddress CurrentContactAddress
        {
            get { return _currentContactAddress; }
            set
            {
                if (_currentContactAddress != value)
                {
                    _currentContactAddress = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}