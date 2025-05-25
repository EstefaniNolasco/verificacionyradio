using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);

            if (rbsuma.Checked == true)
                r = a + b ;

            if (rbmultiplicar.Checked == true)
                r = a * b;

            if (rbdividir.Checked == true)
                r = a / b;

            if (Rbresta.Checked == true)
                r = a - b;

            lblresultado.Text = r.ToString();


        }
    }
}
