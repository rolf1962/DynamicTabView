namespace DynamicTabView.ViewModels
{
    using System;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class TabFormContactsViewModel : TabControlUserControlViewModel
    {
        public TabFormContactsViewModel(TabPageUserControlSelector tabPageUserControlSelector) : base(tabPageUserControlSelector)
        {
            ContactsUserControlViewModel.CurrentContactChanged += ContactsUserControlViewModel_CurrentContactChanged;

            TabPageUserControlViewModels.AddRange(new TabPageUserControlViewModel[]
            {
                ContactsUserControlViewModel,
                ContactsAddressesUserControlViewModel,
                ContactsCommunicationsUserControlViewModel
            });
        }

        private void ContactsUserControlViewModel_CurrentContactChanged(object sender, EventArgs e)
        {
            ContactsAddressesUserControlViewModel.CurrentContact = ContactsUserControlViewModel.CurrentContact;
            ContactsCommunicationsUserControlViewModel.CurrentContact = ContactsUserControlViewModel.CurrentContact;
        }

        public ContactsAddressesUserControlViewModel ContactsAddressesUserControlViewModel { get; }
            = new ContactsAddressesUserControlViewModel();
        public ContactsCommunicationsUserControlViewModel ContactsCommunicationsUserControlViewModel { get; }
            = new ContactsCommunicationsUserControlViewModel();
        public ContactsUserControlViewModel ContactsUserControlViewModel { get; }
            = new ContactsUserControlViewModel();
    }
}
