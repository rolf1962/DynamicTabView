namespace DynamicTabView.ViewModels
{
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public class TabFormSettingsViewModel : TabControlUserControlViewModel
    {
        public TabFormSettingsViewModel(TabPageUserControlSelector tabPageUserControlSelector) : base(tabPageUserControlSelector)
        {
            TabPageUserControlViewModels.AddRange(new TabPageUserControlViewModel[]
            {
                SettingsPathsUserControlViewModel,
            });
        }
        public SettingsPathsUserControlViewModel SettingsPathsUserControlViewModel { get; } = new SettingsPathsUserControlViewModel();
    }
}
