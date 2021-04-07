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
    public partial class Form1 : Form
    {
        public Form1()
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

            if (comboBox1.SelectedIndex == 0)  //suma
            {
                resultado = n1 + n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (comboBox1.SelectedIndex == 1)  //resta
            {
                resultado = n1 - n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (comboBox1.SelectedItem.Equals("Multiplicacion"))  //resta
            {
                resultado = n1 * n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (comboBox1.SelectedItem.ToString() == ("Divicion"))  //resta
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    txtRespuesta.Text = Convert.ToString(resultado);
                }
                else
                {
                    MessageBox.Show("El valor del numero dos debe ser distinto a cero....", "Operaciones Aritmeticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar la operacion...", "Operaciones Aritmeticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
