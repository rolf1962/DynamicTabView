﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViVA.LZPD.Exportmodul.DynamicTabControl.UserControls;
using DynamicTabView.ViewModels;

namespace DynamicTabView.UserControls
{
    public partial class SettingsColorsUserControl : TabPageUserControl
    {
        public SettingsColorsUserControl(SettingsColorsUserControlViewModel settingsColorsUserControlViewModel) : base(settingsColorsUserControlViewModel)
        {
            InitializeComponent();
        }
    }
}
