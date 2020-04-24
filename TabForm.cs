using DynamicTabView.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTabView.TabPages
{
    public partial class TabForm : Form
    {
        private TabFormViewModelBase _dataContext;
        public TabForm()
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
                
                tabControl.TabPages.Clear();

                foreach(var x in _dataContext.TabPageViewModels)
                {
                    UserControl userControl = UserControlSelector.SelectUserControl(x);
                    if (userControl is UserControlBase) AddTabPage(userControl as UserControlBase);
                }
            }
        }

        private void AddTabPage(UserControlBase userControl)
        {
            TabPage tabPage = new TabPage(userControl.Title);
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
        }
    }
}
