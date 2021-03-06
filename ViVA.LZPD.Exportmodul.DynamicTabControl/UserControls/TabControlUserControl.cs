﻿namespace ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public partial class TabControlUserControl : UserControl
    {
        private TabControlUserControlViewModel _dataContext;

        public TabControlUserControl()
        {
            InitializeComponent();

        }

        [Description("Eine Implementierung der abstrakten Klasse \"TabControlUserControlViewModel\"."), Category("DynamicTabControl")]
        public TabControlUserControlViewModel DataContext
        {
            get { return _dataContext; }
            set
            {
                _dataContext = value;

                if (_dataContext == null)
                {
                    return;
                }

                tabControl.TabPages.Clear();

                foreach (TabPageUserControlViewModel tabPageUserControlViewModel in _dataContext.TabPageUserControlViewModels)
                {
                    AddTabPage(_dataContext.TabPageUserControlSelector.SelectUserControl(tabPageUserControlViewModel));
                }
            }
        }

        private void AddTabPage(TabPageUserControl userControl)
        {
            TabPage tabPage = new TabPage();
            tabPage.DataBindings.Add(nameof(TabPage.Text), userControl.DataContext.TabText, null);
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
        }
    }
}
