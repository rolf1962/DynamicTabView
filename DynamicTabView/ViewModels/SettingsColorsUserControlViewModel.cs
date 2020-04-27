using DynamicTabView.Model;
using System.Windows.Media;

namespace DynamicTabView.ViewModels
{
    public class SettingsColorsUserControlViewModel : ViewModelBase
    {
        public SettingsColorsUserControlViewModel()
        {
            SettingsColors = new SettingsColors();
        }

        public SettingsColorsUserControlViewModel(SettingsColors settingsColors)
        {
            SettingsColors = settingsColors;
        }

        private SettingsColors SettingsColors { get; }

        public Color BackgroundColor
        {
            get { return SettingsColors.BackgroundColor; }
            set
            {
                if (SettingsColors.BackgroundColor != value)
                {
                    SettingsColors.BackgroundColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color TextColor
        {
            get { return SettingsColors.TextColor; }
            set
            {
                if (SettingsColors.TextColor != value)
                {
                    SettingsColors.TextColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color BorderColor
        {
            get { return SettingsColors.BorderColor; }
            set
            {
                if (SettingsColors.BorderColor != value)
                {
                    SettingsColors.BorderColor = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}