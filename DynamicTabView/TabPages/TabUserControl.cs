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

namespace DynamicTabView.TabPages
{
    public partial class TabUserControl : UserControl
    {
        private TabFormViewModelBase _dataContext;

        public TabUserControl()
        {
            InitializeComponent();
        }

        public override string Text { get => base.Text; set => base.Text = value; }

        public TabFormViewModelBase DataContext
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
                    UserControl userControl = UserControlSelector.SelectUserControl(x);
                    if (userControl is PageUserControl) AddTabPage(userControl as PageUserControl);
                }
            }
        }

        private void AddTabPage(PageUserControl userControl)
        {
            TabPage tabPage = new TabPage(userControl.Title);
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
        }
    }
}
