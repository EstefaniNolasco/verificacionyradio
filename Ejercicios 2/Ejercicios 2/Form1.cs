using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicios_2
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

       

        

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (listBox1.SelectedItem != null) ;
            }
            {
                txtResultado.Text = listBox1.SelectedItem.ToString();
            }
        }

       

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           listBox1.Items.Add("TITANIC");
            listBox1.Items.Add("RAPIDOS Y FURIOSOS");
            listBox1.Items.Add("LOS VENGADORES");
            listBox1.Items.Add("AMERICAN PIE");
            listBox1.Items.Add("HUGO");

        }
    }
}
