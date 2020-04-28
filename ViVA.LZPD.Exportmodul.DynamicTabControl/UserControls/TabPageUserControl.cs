namespace ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels;

    public partial class TabPageUserControl : UserControl
    {
        /// <summary>
        /// Der Standardkonstruktor wird vom Designer benötigt. Der kommt auch klar, wenn er "private" ist.
        /// </summary>
        private TabPageUserControl() { }

        public TabPageUserControl(TabPageUserControlViewModel tabPageUserControlViewModel)
        {
            InitializeComponent();
            if (tabPageUserControlViewModel == null)
            {
                throw new ArgumentNullException(nameof(tabPageUserControlViewModel));
            }

            DataContext = tabPageUserControlViewModel;
        }

        [Description("Der Text, der auf dem Tab angezeigt wird."), Category("DynamicTabControl")]
        public string Title { get; set; }

        [Description("Eine Implementierung der abstrakten Klasse \"TabPageUserControlViewModel\"."), Category("DynamicTabControl")]
        public TabPageUserControlViewModel DataContext { get; }
    }
}
