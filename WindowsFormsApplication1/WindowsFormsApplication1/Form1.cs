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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cl;
            cl = new Class1();

            string date = cl.GetDate();
            string time = cl.GetTime();

            MessageBox.Show(date + " " + time);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 cl;
            cl = new Class1();

            string date = cl.GetDate2();
            string time = cl.GetTime2();

            MessageBox.Show(date + " " + time);

        }
    }
}
