namespace ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class TabControlUserControlViewModel
    {
        public TabControlUserControlViewModel(TabPageUserControlSelector tabPageUserControlSelector)
        {
            if (tabPageUserControlSelector == null) throw new ArgumentNullException(nameof(tabPageUserControlSelector));

            TabPageUserControlSelector = tabPageUserControlSelector;
        }

        public List<TabPageUserControlViewModel> TabPageUserControlViewModels { get; } = new List<TabPageUserControlViewModel>();
        public TabPageUserControlSelector TabPageUserControlSelector { get; }
    }
}
