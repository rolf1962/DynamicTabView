namespace DynamicTabView.UserControls
{
    using DynamicTabView.Model;
    using DynamicTabView.ViewModels;
    using System;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;

    public partial class ContactsUserControl : TabPageUserControl
    {
        public ContactsUserControl(ContactsUserControlViewModel contactsUserControlViewModel) : base(contactsUserControlViewModel)
        {
            InitializeComponent();

            BindingSource.DataSource = DataContext;

            if (contactsComboBox.SelectedItem != null)
            {
                ((ContactsUserControlViewModel)DataContext).CurrentContact = contactsComboBox.SelectedItem as Contact;
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
