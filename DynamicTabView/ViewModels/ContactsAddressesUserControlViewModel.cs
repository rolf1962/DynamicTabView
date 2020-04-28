namespace DynamicTabView.ViewModels
{
    using DynamicTabView.Model;
    using System.Collections.Generic;
    using System.Linq;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class ContactsAddressesUserControlViewModel : TabPageUserControlViewModel
    {
        private ContactAddress _currentContactAddress;
        private Contact _currentContact;

        public ContactsAddressesUserControlViewModel()
        {
        }

        public List<ContactAddress> ContactAddresses
        {
            get
            {
                return 
                    null == CurrentContact ? 
                    new List<ContactAddress>() : 
                    new List<ContactAddress>(CurrentContact.Addresses);
            }
        }

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
                    CurrentContactAddress = ContactAddresses.FirstOrDefault();
                }
            }
        }
    }
}