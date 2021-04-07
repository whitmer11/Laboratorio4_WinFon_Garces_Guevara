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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtRespuesta.Text = "";
        }
        private void botonCalcular_Click(object sender, EventArgs e)
        {

            //declarar variables
            double n1, n2, resultado;

            //capturando los valores de las cajas de texto en las variables
            n1 = double.Parse(txtNumber1.Text);
            n2 = Convert.ToDouble(txtNumber2.Text);

            if (rbtnSuma.Checked == true)//suma
            {
                resultado = n1 + n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (rbtnResta.Checked == true)//resta
            {
                resultado = n1 - n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (rbtnMultiplicacion.Checked == true)//multiplicacion
            {
                resultado = n1 * n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (rbtnDivision.Checked == true) //division
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    txtRespuesta.Text = string.Format("{0:n2}", (Math.Truncate(resultado * 100) / 100));
                }
                else
                {
                    MessageBox.Show("El valor del numero dos debe ser distinto a cero...", "operaciones aritmeticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nose puede realizar la operacion...", "Operaciones Aritmeticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}