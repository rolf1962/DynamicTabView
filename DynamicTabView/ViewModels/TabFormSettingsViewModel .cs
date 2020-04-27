using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabView.ViewModels
{
    public class TabFormSettingsViewModel : TabControlUserControlViewModel
    {
        public TabFormSettingsViewModel()
        {
            TabPageViewModels.AddRange(new object[] { SettingsPathsUserControlViewModel, SettingsColorsUserControlViewModel });
        }
        public SettingsColorsUserControlViewModel SettingsColorsUserControlViewModel { get; } = new SettingsColorsUserControlViewModel();
        public SettingsPathsUserControlViewModel SettingsPathsUserControlViewModel { get; } = new SettingsPathsUserControlViewModel();
    }
}
