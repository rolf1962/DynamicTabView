namespace ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public partial class TabPageUserControl : UserControl
    {
        private TabPageUserControlViewModel _dataContext;

        public TabPageUserControl()
        {
            InitializeComponent();
        }

        [Description("Der Text, der auf dem Tab angezeigt wird."), Category("DynamicTabControl")]
        public string Title { get; set; }

        [Description("Eine Implementierung der abstrakten Klasse \"TabPageUserControlViewModel\"."), Category("DynamicTabControl")]
        public TabPageUserControlViewModel DataContext
        {
            get { return _dataContext; }
            set
            {
                if (_dataContext != value)
                {
                    _dataContext = value;
                    OnDataContextChanged(EventArgs.Empty);
                }
            }
        }

        protected event EventHandler DataContextChanged;
        private void OnDataContextChanged(EventArgs e)
        {
            DataContextChanged?.Invoke(this, e);
        }
    }
}
