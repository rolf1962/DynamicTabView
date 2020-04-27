namespace DynamicTabView
{
    using DynamicTabView.ViewModels;
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonContactsClick(object sender, EventArgs e)
        {
            Text = "Kontakte";
            tabUserControl.DataContext = new TabFormContactsViewModel() { TabPageUserControlSelector = new TabPageUserControlSelector() };
        }

        private void ButtonSettingsClick(object sender, EventArgs e)
        {
            Text = "Einstellungen";
            tabUserControl.DataContext = new TabFormSettingsViewModel() { TabPageUserControlSelector = new TabPageUserControlSelector() };
        }
    }
}
