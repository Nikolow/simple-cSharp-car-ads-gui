﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin_Choose : Form
    {
        public Admin_Choose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_ADs mm = new Admin_ADs();
            mm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Clients mm = new Admin_Clients();
            mm.Show();
            this.Close();
        }
    }
}
