using DynamicTabView.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DynamicTabView.ViewModels
{
    public class ContactsCommunicationsUserControlViewModel : ViewModelBase
    {
        private ContactCommunication _currentContactCommunication;

        public ContactsCommunicationsUserControlViewModel()
        {
            ContactCommunications = new ObservableCollection<ContactCommunication>();
        }

        public ObservableCollection<ContactCommunication> ContactCommunications { get; }

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
    }
}