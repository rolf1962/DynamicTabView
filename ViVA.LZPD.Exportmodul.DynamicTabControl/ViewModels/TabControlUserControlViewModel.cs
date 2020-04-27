namespace ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels
{
    using System.Collections.Generic;

    public class TabControlUserControlViewModel
    {
        public List<TabPageUserControlViewModel> TabPageUserControlViewModels { get; } = new List<TabPageUserControlViewModel>();
        public TabPageUserControlSelector TabPageUserControlSelector { get; set; }
    }
}
