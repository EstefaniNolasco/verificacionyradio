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

namespace Ejercicios
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            string texto = TXT1.Text;
            FontStyle estilo = FontStyle.Regular;

            if (CHK1.Checked)
                estilo |= FontStyle.Bold;
            if (CHK2.Checked)
                estilo |= FontStyle.Italic;
            if (CHK3.Checked)
                estilo |= FontStyle.Underline;
            if (CHK4.Checked)
                estilo |= FontStyle.Strikeout;

            LBL1.Text = texto;
            lbl2.Font = new Font("Arial", 12, estilo);

        }
    }
}
