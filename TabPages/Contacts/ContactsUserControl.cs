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
using DynamicTabView.Model;

namespace DynamicTabView.TabPages
{
    public partial class ContactsUserControl : UserControlBase
    {
        public ContactsUserControl()
        {
            InitializeComponent();
            base.DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, EventArgs e)
        {
            if (DataContext is ContactsUserControlViewModel)
            {
                BindingSource.DataSource = DataContext;
            }
        }
    }
}
