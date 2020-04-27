﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTabView.UserControls
{
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