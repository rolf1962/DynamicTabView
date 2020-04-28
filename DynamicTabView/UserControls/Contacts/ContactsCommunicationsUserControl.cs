namespace DynamicTabView.UserControls
{
    using DynamicTabView.Model;
    using DynamicTabView.ViewModels;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;

    public partial class ContactsCommunicationsUserControl : TabPageUserControl
    {
        public ContactsCommunicationsUserControl(ContactsCommunicationsUserControlViewModel contactsCommunicationsUserControlViewModel) : base(contactsCommunicationsUserControlViewModel)
        {
            InitializeComponent();

            BindingSource.DataSource = DataContext;

            if (communicationsComboBox.SelectedItem != null)
            {
                ((ContactsCommunicationsUserControlViewModel)DataContext).CurrentContactCommunication = communicationsComboBox.SelectedItem as ContactCommunication;
            }
        }
    }
}
