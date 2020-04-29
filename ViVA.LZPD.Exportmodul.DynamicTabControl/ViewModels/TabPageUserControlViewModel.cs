namespace ViVA.LZPD.Exportmodul.DynamicTabControl.ViewModels
{
    public abstract class TabPageUserControlViewModel : ViewModelBase 
    {
        private string _tabText;

        public TabPageUserControlViewModel()
        {
            TabText = "Neuer Tab";
        }

        public string TabText
        {
            get { return _tabText; }
            set
            {
                if (_tabText != value)
                {
                    _tabText = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
