﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardBiometrics
{
    public partial class LoggedWindow : Form
    {
        string name=null;
        public LoggedWindow(string name)
        {
            this.name = name;
            InitializeComponent();
            labelName.Text = name;

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            KeyboardBiometrics keyboardBiometrics = new KeyboardBiometrics();
            this.Hide();
            keyboardBiometrics.Show();
        }
    }
}
