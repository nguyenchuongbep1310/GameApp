﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApp
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }
    }
}
