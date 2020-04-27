namespace DynamicTabView.ViewModels
{
    using DynamicTabView.DataAccess;
    using DynamicTabView.Model;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class SettingsPathsUserControlViewModel : TabPageUserControlViewModel
    {
        public SettingsPathsUserControlViewModel()
        {
            SettingsPaths = ContactsContext.Instance.SettingsPaths;
        }

        public SettingsPaths SettingsPaths { get; }
    }
}