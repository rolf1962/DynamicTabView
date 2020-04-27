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
                return new ContactsUserControl() { DataContext = tabPageUserControlViewModel };
            }
            if (tabPageUserControlViewModel is ContactsAddressesUserControlViewModel)
            {
                return new ContactsAddressesUserControl() { DataContext = tabPageUserControlViewModel };
            }
            if (tabPageUserControlViewModel is ContactsCommunicationsUserControlViewModel)
            {
                return new ContactsCommunicationsUserControl() { DataContext = tabPageUserControlViewModel };
            }
            if (tabPageUserControlViewModel is SettingsColorsUserControlViewModel)
            {
                return new SettingsColorsUserControl() { DataContext = tabPageUserControlViewModel };
            }
            if (tabPageUserControlViewModel is SettingsPathsUserControlViewModel)
            {
                return new SettingsPathsUserControl() { DataContext = tabPageUserControlViewModel };
            }

            return null;
        }
    }
}
