namespace ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public partial class TabControlUserControl : UserControl
    {
        public TabControlUserControl(List<TabPageUserControlViewModel> tabPageUserControlViewModels, TabPageUserControlSelector tabPageUserControlSelector)
        {
            InitializeComponent();

            if (null == tabPageUserControlViewModels) { throw new ArgumentNullException(nameof(tabPageUserControlViewModels)); }
            if (null == tabPageUserControlSelector) { throw new ArgumentNullException(nameof(tabPageUserControlSelector)); }

            TabPageUserControlViewModels = tabPageUserControlViewModels;
            TabPageUserControlSelector = tabPageUserControlSelector;

            tabControl.TabPages.Clear();

            foreach (TabPageUserControlViewModel tabPageUserControlViewModel in TabPageUserControlViewModels)
            {
                AddTabPage(TabPageUserControlSelector.SelectUserControl(tabPageUserControlViewModel));
            }
        }

        private void AddTabPage(TabPageUserControl userControl)
        {
            TabPage tabPage = new TabPage(userControl.Title);
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
        }

        public List<TabPageUserControlViewModel> TabPageUserControlViewModels { get; } = new List<TabPageUserControlViewModel>();
        public TabPageUserControlSelector TabPageUserControlSelector { get; set; }
    }
}
