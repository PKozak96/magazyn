﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczalniaAut
{
    public partial class Menu_Glowne : Form
    {
        public Menu_Glowne()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}