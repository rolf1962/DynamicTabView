using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTabView.TabPages
{
    public partial class TabPageBase : UserControl
    {
        public TabPageBase()
        {
            InitializeComponent();
        }

        public string Title { get; set; }
    }
}
