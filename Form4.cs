using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio4_WinFon_Garces_Guevara
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2;
            string resultado;

            n1 = double.Parse(txtNumber1.Text);
            n2 = double.Parse(txtNumber2.Text);

            if (n1 > n2)
            {
                resultado = "Numero 1 es mayor que numero 2";
                txtRespuesta.Text = resultado.ToString();
            }
            else if (n2 > n1)
            {
                resultado = "Numero 2 es mayor que numero 1";
                txtRespuesta.Text = resultado.ToString();
            }
            else if (n1.Equals(n2))
            {
                resultado = "Ambos numeros son iguales";
                txtRespuesta.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("No se puede comparar los resultados...", "numero mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtRespuesta.Text = "";
        }


    }
}
