﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("D:\\demo\\demo.txt");
            txt.Write(TextWriter.Text);
            txt.Close(); 
        }

        private void TextWriter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
