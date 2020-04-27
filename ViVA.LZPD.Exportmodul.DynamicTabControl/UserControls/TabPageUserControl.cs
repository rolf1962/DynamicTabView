namespace ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls
{
    using System;
    using System.Windows.Forms;

    public partial class TabPageUserControl : UserControl
    {
        private object _dataContext;

        public TabPageUserControl()
        {
            InitializeComponent();
        }

        public string Title { get; set; }

        public object DataContext
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
