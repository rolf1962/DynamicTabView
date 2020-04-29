namespace DynamicTabView.UserControls
{
    using DynamicTabView.Model;
    using DynamicTabView.ViewModels;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;

    public partial class ContactsCommunicationsUserControl : TabPageUserControl
    {
        public ContactsCommunicationsUserControl()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, System.EventArgs e)
        {
            BindingSource.DataSource = DataContext;

            if (communicationsComboBox.SelectedItem != null && 
                ((ContactsCommunicationsUserControlViewModel)DataContext).CurrentContactCommunication == null)
            {
                ((ContactsCommunicationsUserControlViewModel)DataContext).CurrentContactCommunication = 
                    communicationsComboBox.SelectedItem as ContactCommunication;
            }
        }
    }
}
