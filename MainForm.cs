using DynamicTabView.TabPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTabView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonContactsClick(object sender, EventArgs e)
        {
            TabForm dlg = new TabForm() { Text = "Kontakte" };

            dlg.AddTabPage(new ContactUserControl());
            dlg.AddTabPage(new ContactAdressesUserControl());
            dlg.AddTabPage(new ContactCommunicationsUserControl());

            dlg.ShowDialog(this);
        }

        private void ButtonSettingsClick(object sender, EventArgs e)
        {
            TabForm dlg = new TabForm() { Text = "Einstellungen" }; ;

            dlg.AddTabPage(new SettingsPathsUserControl());
            dlg.AddTabPage(new SettingsColorsUserControl());

            dlg.ShowDialog(this);
        }

        private void ButtonAllTogetherClick(object sender, EventArgs e)
        {
            TabForm dlg = new TabForm() { Text = "Kontakte und Einstellungen" };

            dlg.AddTabPage(new ContactUserControl());
            dlg.AddTabPage(new ContactAdressesUserControl());
            dlg.AddTabPage(new ContactCommunicationsUserControl());
            dlg.AddTabPage(new SettingsPathsUserControl());
            dlg.AddTabPage(new SettingsColorsUserControl());

            dlg.ShowDialog(this);

        }
    }
}
