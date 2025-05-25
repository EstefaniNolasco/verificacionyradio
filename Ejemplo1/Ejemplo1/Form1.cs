using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (CHKMONITOR.Checked == true)
            total = total + 250;

            if(CHKTECLADO.Checked == true)
            total = total + 15; ;

            if (CHKMOUSE.Checked == true)
                total = total + 20;

            MessageBox.Show("El total es " + total.ToString());


        }

        private void CHKMONITOR_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKMONITOR.Checked == true)
                label1.Text = "Monitor";
            else
                label1.Text = "";
        }
    }
}
