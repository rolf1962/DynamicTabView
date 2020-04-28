using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;
using DynamicTabView.ViewModels;
using DynamicTabView.Model;

namespace DynamicTabView.UserControls
{
    public partial class ContactsCommunicationsUserControl : TabPageUserControl
    {
        public ContactsCommunicationsUserControl()
        {
            InitializeComponent();
            base.DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsCommunicationsUserControlViewModel)
            {
                BindingSource.DataSource = DataContext;

                if (communicationsComboBox.SelectedItem != null)
                {
                    ((ContactsCommunicationsUserControlViewModel)DataContext).CurrentContactCommunication = communicationsComboBox.SelectedItem as ContactCommunication;
                }
            }
        }

        private void communicationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsCommunicationsUserControlViewModel && communicationsComboBox.SelectedItem != null)
            {
                ((ContactsCommunicationsUserControlViewModel)DataContext).CurrentContactCommunication = communicationsComboBox.SelectedItem as ContactCommunication;
            }
        }
    }
}
