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
    public partial class ContactsAddressesUserControl : TabPageUserControl
    {
        public ContactsAddressesUserControl()
        {
            InitializeComponent();
            base.DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsAddressesUserControlViewModel)
            {
                BindingSource.DataSource = DataContext;

                if (addressesComboBox.SelectedItem != null)
                {
                    ((ContactsAddressesUserControlViewModel)DataContext).CurrentContactAddress = addressesComboBox.SelectedItem as ContactAddress;
                }
            }
        }

        private void addressesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsAddressesUserControlViewModel && addressesComboBox.SelectedItem != null)
            {
                ((ContactsAddressesUserControlViewModel)DataContext).CurrentContactAddress = addressesComboBox.SelectedItem as ContactAddress;
            }
        }
    }
}
