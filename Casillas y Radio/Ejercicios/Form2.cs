using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string Seleccionado = "";
            string Mensajes = "";

            if (RB1.Checked) Seleccionado= "Python";
            else if (RB2.Checked) Seleccionado = "PHP";
            else if (RB3.Checked) Seleccionado= "Perl";
            else if (RB4.Checked) Seleccionado = "Ruby";

            if (CHB1.Checked)
                Mensajes = "Has aceptado los términos";
            else
                Mensajes = "No has aceptado los términos";



            lbl1.Text = Seleccionado + " " + "ha sido seleccionado ";
            lbl2.Text = Mensajes;



        }
    }
}
