﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuevoelemento = textBox2.Text.Trim();
            if(!
                string.IsNullOrEmpty(nuevoelemento))

            textBox2.Focus();
            listBox1.Items.Add(nuevoelemento);
            textBox2.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null);

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
