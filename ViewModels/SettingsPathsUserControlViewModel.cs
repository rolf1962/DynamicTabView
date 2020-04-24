using DynamicTabView.Model;

namespace DynamicTabView.ViewModels
{
    public class SettingsPathsUserControlViewModel : ViewModelBase
    {
        public SettingsPathsUserControlViewModel()
        {
            SettingsPaths = new SettingsPaths();
        }

        public SettingsPathsUserControlViewModel(SettingsPaths settingsPaths)
        {
            SettingsPaths = settingsPaths;
        }

        private SettingsPaths SettingsPaths { get; }

        public string StoragePath
        {
            get { return SettingsPaths.StoragePath; }
            set
            {
                if (SettingsPaths.StoragePath != value)
                {
                    SettingsPaths.StoragePath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ImageLibraryPath
        {
            get { return SettingsPaths.ImageLibraryPath; }
            set
            {
                if (SettingsPaths.ImageLibraryPath != value)
                {
                    SettingsPaths.ImageLibraryPath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string TempPath
        {
            get { return SettingsPaths.TempPath; }
            set
            {
                if (SettingsPaths.TempPath != value)
                {
                    SettingsPaths.TempPath = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}