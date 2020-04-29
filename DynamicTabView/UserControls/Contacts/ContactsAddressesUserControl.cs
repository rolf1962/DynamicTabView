namespace DynamicTabView.UserControls
{
    using DynamicTabView.Model;
    using DynamicTabView.ViewModels;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;

    public partial class ContactsAddressesUserControl : TabPageUserControl
    {
        public ContactsAddressesUserControl()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, System.EventArgs e)
        {
            BindingSource.DataSource = DataContext;

            if (addressesComboBox.SelectedItem != null && 
                ((ContactsAddressesUserControlViewModel)DataContext).CurrentContactAddress == null)
            {
                ((ContactsAddressesUserControlViewModel)DataContext).CurrentContactAddress = 
                    addressesComboBox.SelectedItem as ContactAddress;
            }
        }
    }
}
