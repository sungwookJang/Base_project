﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MemberRegisterForm mrf;
        private void btn_reg_Click(object sender, EventArgs e)
        {
            mrf = new MemberRegisterForm();
            mrf.ShowDialog();
            mrf.FormClosed += Mrf_FormClosed;
        }

        private void Mrf_FormClosed(object sender, FormClosedEventArgs e)
        {
            mrf = null;
        }

       
    }
}
