namespace DynamicTabView.ViewModels
{
    using DynamicTabView.DataAccess;
    using DynamicTabView.Model;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class SettingsColorsUserControlViewModel : TabPageUserControlViewModel
    {
        public SettingsColorsUserControlViewModel()
        {
            SettingsColors = ContactsContext.Instance.SettingsColors;
        }

        private SettingsColors SettingsColors { get; }
    }
}