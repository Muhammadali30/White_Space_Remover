﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remove_White_Spaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
          richTextBox1.Text=  richTextBox1.Text.Replace(" ",string.Empty);
            richTextBox1.Text = richTextBox1.Text.Replace("\n", string.Empty);

        }

    }
}
