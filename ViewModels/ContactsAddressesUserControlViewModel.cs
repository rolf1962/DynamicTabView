using DynamicTabView.Model;
using System.Collections.Generic;

namespace DynamicTabView.ViewModels
{
    public class ContactsAddressesUserControlViewModel : ViewModelBase
    {
        private ContactAddress _currentContactAddress;
        private Contact _currentContact;

        public ContactsAddressesUserControlViewModel()
        {
        }

        public ICollection<ContactAddress> ContactAddresses { get { return CurrentContact?.Addresses; } }

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

        public Contact CurrentContact
        {
            get { return _currentContact; }
            set
            {
                if (_currentContact != value)
                {
                    _currentContact = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}