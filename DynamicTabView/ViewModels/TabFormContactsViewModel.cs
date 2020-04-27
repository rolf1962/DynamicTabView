using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabView.ViewModels
{
    public class TabFormContactsViewModel : TabControlUserControlViewModel
    {
        public TabFormContactsViewModel()
        {
            ContactsUserControlViewModel.CurrentContactChanged += ContactsUserControlViewModel_CurrentContactChanged;
            TabPageViewModels.AddRange(new object[] { ContactsUserControlViewModel, ContactsAddressesUserControlViewModel, ContactsCommunicationsUserControlViewModel });
        }

        private void ContactsUserControlViewModel_CurrentContactChanged(object sender, EventArgs e)
        {
            ContactsAddressesUserControlViewModel.CurrentContact = ContactsUserControlViewModel.CurrentContact;
            ContactsCommunicationsUserControlViewModel.CurrentContact = ContactsUserControlViewModel.CurrentContact;
        }

        public ContactsAddressesUserControlViewModel ContactsAddressesUserControlViewModel { get; } = new ContactsAddressesUserControlViewModel();
        public ContactsCommunicationsUserControlViewModel ContactsCommunicationsUserControlViewModel { get; } = new ContactsCommunicationsUserControlViewModel();
        public ContactsUserControlViewModel ContactsUserControlViewModel { get; } = new ContactsUserControlViewModel();
    }
}
