﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiTK_Algorytmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void btnSzyfr_Click(object sender, EventArgs e)
        {
            loadform(new szyfrowanieform());
        }

        private void btnAlgor_Click(object sender, EventArgs e)
        {
            loadform(new algorytmyform());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new podpiscyfrowy());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new HuffmanHamingienForm());
        }
    }
}
