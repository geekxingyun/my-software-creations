﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseConversionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.ToString().Trim().ToLower();
            textBox2.Text = textBox1.Text.ToString().Trim().ToUpper();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
             textBox1.Text="";
             textBox2.Text="";
        }

    }
}
