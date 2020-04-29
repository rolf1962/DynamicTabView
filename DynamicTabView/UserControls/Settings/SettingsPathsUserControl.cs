namespace DynamicTabView.UserControls
{
    using DynamicTabView.ViewModels;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;

    public partial class SettingsPathsUserControl : TabPageUserControl
    {
        public SettingsPathsUserControl()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, System.EventArgs e)
        {
            BindingSource.DataSource = DataContext;
        }
    }
}
