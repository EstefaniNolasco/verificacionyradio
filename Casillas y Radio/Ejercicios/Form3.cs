using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string Color = "";

            if (RB1.Checked) Color = "Rojo";
            else if (RB2.Checked) Color = "Verde";
            else if (RB3.Checked) Color = "Azul";

            lbl1.Text =" Color elegido:" + " " + Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
