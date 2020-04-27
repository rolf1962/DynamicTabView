using DynamicTabView.DataAccess;
using DynamicTabView.TabPages;
using DynamicTabView.ViewModels;
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
            Text = "Kontakte";
            tabUserControl.DataContext = new TabFormContactsViewModel();
        }

        private void ButtonSettingsClick(object sender, EventArgs e)
        {
            Text = "Einstellungen";
            tabUserControl.DataContext=new TabFormSettingsViewModel(); 
        }
    }
}
