﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milksploit
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Auto inject not integrated.");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/tKE7hDXYUF");
        }
    }
}
