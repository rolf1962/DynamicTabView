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

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [Description("Der Text, der auf dem Tab angezeigt wird."), Category("DynamicTabControl")]
        public override string Text { get; set; }

        [Description("Eine Implementierung der abstrakten Klasse \"TabPageUserControlViewModel\"."), Category("DynamicTabControl")]
        public TabPageUserControlViewModel DataContext 
        {
            get { return _dataContext; }
            set
            {
                if (_dataContext != value)
                {
                    _dataContext = value;
                    NotifyDataContextChanged();
                }
            }
        }

        public event EventHandler DataContextChanged;
        public void NotifyDataContextChanged()
        {
            DataContextChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
