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
            TabPageUserControl tabPageUserControl = null;

            if (tabPageUserControlViewModel is ContactsUserControlViewModel)
            {
                tabPageUserControl = new ContactsUserControl();
            }
            if (tabPageUserControlViewModel is ContactsAddressesUserControlViewModel)
            {
                tabPageUserControl = new ContactsAddressesUserControl();
            }
            if (tabPageUserControlViewModel is ContactsCommunicationsUserControlViewModel)
            {
                tabPageUserControl = new ContactsCommunicationsUserControl();
            }
            if (tabPageUserControlViewModel is SettingsPathsUserControlViewModel)
            {
                tabPageUserControl = new SettingsPathsUserControl();
            }

            if (null != tabPageUserControl)
            {
                tabPageUserControl.DataContext = tabPageUserControlViewModel;
            }

            return tabPageUserControl;
        }
    }
}
