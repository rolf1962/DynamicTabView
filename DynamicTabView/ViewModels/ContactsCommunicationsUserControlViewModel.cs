namespace DynamicTabView.ViewModels
{
    using DynamicTabView.Model;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class ContactsCommunicationsUserControlViewModel : TabPageUserControlViewModel
    {
        private ContactCommunication _currentContactCommunication;
        private Contact _currentContact;

        public ContactsCommunicationsUserControlViewModel()
        {
        }

        public ObservableCollection<ContactCommunication> ContactCommunications { get { return new ObservableCollection<ContactCommunication>(CurrentContact?.Communications); } }

        public ContactCommunication CurrentContactCommunication
        {
            get { return _currentContactCommunication; }
            set
            {
                if (_currentContactCommunication != value)
                {
                    _currentContactCommunication = value;
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
                    CurrentContactCommunication = ContactCommunications.FirstOrDefault();
                }
            }
        }
    }
}