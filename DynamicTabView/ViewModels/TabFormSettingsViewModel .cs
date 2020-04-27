namespace DynamicTabView.ViewModels
{
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class TabFormSettingsViewModel : TabControlUserControlViewModel
    {
        public TabFormSettingsViewModel()
        {
            TabPageUserControlViewModels.AddRange(new TabPageUserControlViewModel[] 
            { 
                SettingsPathsUserControlViewModel, 
                SettingsColorsUserControlViewModel 
            });
        }
        public SettingsColorsUserControlViewModel SettingsColorsUserControlViewModel { get; } = new SettingsColorsUserControlViewModel();
        public SettingsPathsUserControlViewModel SettingsPathsUserControlViewModel { get; } = new SettingsPathsUserControlViewModel();
    }
}
