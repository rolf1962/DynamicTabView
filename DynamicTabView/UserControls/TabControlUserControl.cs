using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicTabView.ViewModels;

namespace DynamicTabView.UserControls
{
    public partial class TabControlUserControl : UserControl
    {
        private TabControlUserControlViewModel _dataContext;

        public TabControlUserControl()
        {
            InitializeComponent();
        }

        public override string Text { get => base.Text; set => base.Text = value; }

        public TabControlUserControlViewModel DataContext
        {
            get { return _dataContext; }
            set
            {
                _dataContext = value;

                if (_dataContext == null)
                {
                    return;
                }

                tabControl.TabPages.Clear();

                foreach (var x in _dataContext.TabPageViewModels)
                {
                    UserControl userControl = TabPageUserControlSelector.SelectUserControl(x);
                    if (userControl is TabPageUserControl) AddTabPage(userControl as TabPageUserControl);
                }
            }
        }

        private void AddTabPage(TabPageUserControl userControl)
        {
            TabPage tabPage = new TabPage(userControl.Title);
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
        }
    }
}
