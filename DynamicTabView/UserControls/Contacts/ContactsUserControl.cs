using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicTabView.ViewModels;
using DynamicTabView.Model;
using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;

namespace DynamicTabView.UserControls
{
    public partial class ContactsUserControl : TabPageUserControl
    {
        public ContactsUserControl()
        {
            InitializeComponent();
            base.DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsUserControlViewModel)
            {
                BindingSource.DataSource = DataContext;
                
                if (contactsComboBox.SelectedItem != null)
                {
                    ((ContactsUserControlViewModel)DataContext).CurrentContact = contactsComboBox.SelectedItem as Contact;
                }
            }
        }

        private void contactsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsUserControlViewModel && contactsComboBox.SelectedItem != null)
            {
                ((ContactsUserControlViewModel)DataContext).CurrentContact = contactsComboBox.SelectedItem as Contact;
            }
        }
    }
}
