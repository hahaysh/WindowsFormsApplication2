﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string zerg;
        string terran;

        private void button1_Click(object sender, EventArgs e)
        {
            zerg = "지현아";
            terran = "사랑해";
            MessageBox.Show(zerg + terran);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            terran = "사랑해";
            MessageBox.Show(terran);
        }
    }
}