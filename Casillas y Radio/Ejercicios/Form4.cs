using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnorden_Click(object sender, EventArgs e)
        {

            StringBuilder orden = new StringBuilder();

            if (CHK1.Checked) orden.AppendLine("Frijoles fritos");
            if (CHK2.Checked) orden.AppendLine("Huevo picado");
            if (CHK3.Checked) orden.AppendLine("Tortilla");
            if (CHK4.Checked) orden.AppendLine("Café");
            if (CHK5.Checked) orden.AppendLine("Jugo de naranja");
            if (CHK6.Checked) orden.AppendLine("Carne asada");
            if (CHK7.Checked) orden.AppendLine("Chicharrones");
            if (CHK8.Checked) orden.AppendLine("Baleada");
            if (CHK9.Checked) orden.AppendLine("Guineo Verde");
            if (CHK10.Checked) orden.AppendLine("Queso");
            if (CHK11.Checked) orden.AppendLine("Mantequilla");
            if (CHK12.Checked) orden.AppendLine("Sopa de caracol");

            if (orden.Length == 0);

            else
                txt1.Text = orden.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
        
            txt1.Clear();
        }
    }
}
