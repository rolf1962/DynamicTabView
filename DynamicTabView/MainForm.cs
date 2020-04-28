namespace DynamicTabView
{
    using DynamicTabView.ViewModels;
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        TabFormContactsViewModel tabFormContactsViewModel;
        TabFormSettingsViewModel tabFormSettingsViewModel;

        public MainForm()
        {
            InitializeComponent();

            tabFormContactsViewModel = new TabFormContactsViewModel(new TabPageUserControlSelector());
            tabFormSettingsViewModel = new TabFormSettingsViewModel(new TabPageUserControlSelector());
        }

        private void ButtonContactsClick(object sender, EventArgs e)
        {
            Text = "Kontakte";
            tabUserControl.DataContext = tabFormContactsViewModel;
        }

        private void ButtonSettingsClick(object sender, EventArgs e)
        {
            Text = "Einstellungen";
            tabUserControl.DataContext = tabFormSettingsViewModel;
        }
    }
}
