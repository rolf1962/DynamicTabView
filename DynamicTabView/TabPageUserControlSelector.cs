namespace DynamicTabView
{
    using DynamicTabView.UserControls;
    using DynamicTabView.ViewModels;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class TabPageUserControlSelector : ViVA.LZPD.Exportmodul.DynamicTabControl.TabPageUserControlSelector
    {
        public override TabPageUserControl SelectUserControl(TabPageUserControlViewModel tabPageUserControlViewModel)
        {
            if (tabPageUserControlViewModel is ContactsUserControlViewModel)
            {
                return new ContactsUserControl(tabPageUserControlViewModel as ContactsUserControlViewModel);
            }
            if (tabPageUserControlViewModel is ContactsAddressesUserControlViewModel)
            {
                return new ContactsAddressesUserControl(tabPageUserControlViewModel as ContactsAddressesUserControlViewModel);
            }
            if (tabPageUserControlViewModel is ContactsCommunicationsUserControlViewModel)
            {
                return new ContactsCommunicationsUserControl(tabPageUserControlViewModel as ContactsCommunicationsUserControlViewModel);
            }
            if (tabPageUserControlViewModel is SettingsPathsUserControlViewModel)
            {
                return new SettingsPathsUserControl(tabPageUserControlViewModel as SettingsPathsUserControlViewModel);
            }

            return null;
        }
    }
}
