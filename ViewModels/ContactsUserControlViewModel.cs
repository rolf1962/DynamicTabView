using DynamicTabView.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DynamicTabView.ViewModels
{
    public class ContactsUserControlViewModel : ViewModelBase
    {
        private Contact _currentContact;

        public ContactsUserControlViewModel()
        {
            Contacts = new ObservableCollection<Contact>(ContactsContext.Contacts);
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
                }
            }
        }
    }
}