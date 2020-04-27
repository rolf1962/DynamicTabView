namespace ViVA.LZPD.Exportmodul.DynamicTabControl
{
    using System;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public abstract  class TabPageUserControlSelector
    {
        public abstract TabPageUserControl SelectUserControl(TabPageUserControlViewModel tabPageUserControlViewModel);
    }
}
