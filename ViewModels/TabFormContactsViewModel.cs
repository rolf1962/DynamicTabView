using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabView.ViewModels
{
    public class TabFormContactsViewModel : TabFormViewModelBase
    {
        public TabFormContactsViewModel()
        {
            TabPageViewModels.AddRange(new object[] { ContactsUserControlViewModel, ContactsAddressesUserControlViewModel, ContactsCommunicationsUserControlViewModel });
        }

        public ContactsAddressesUserControlViewModel ContactsAddressesUserControlViewModel { get; } = new ContactsAddressesUserControlViewModel();
        public ContactsCommunicationsUserControlViewModel ContactsCommunicationsUserControlViewModel { get; } = new ContactsCommunicationsUserControlViewModel();
        public ContactsUserControlViewModel ContactsUserControlViewModel { get; } = new ContactsUserControlViewModel();
    }
}
