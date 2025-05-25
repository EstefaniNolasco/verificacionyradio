using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string marca = "";
            string modelo = "";

            if (RB1.Checked) marca= "Ferrari";
            else if (RB2.Checked) marca = "Jaguar";
            else if (RB3.Checked) marca= "Mercedes Benz";
            else if (RB4.Checked) marca = "Audi";
            else if (RB5.Checked) marca = "Aston Martin";

            if (RB6.Checked) modelo = "2009";
            else if (RB7.Checked) modelo= "2010";
            else if (RB8.Checked) modelo = "2011";
            else if (RB9.Checked) modelo = "2012";
            else if (RB10.Checked) modelo = "2013";

            
            lblmarca.Text = marca;
            lblModelo.Text = modelo;

        }
    }
}
