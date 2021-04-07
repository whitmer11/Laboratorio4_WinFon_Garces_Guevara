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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lstOperaciones.Items.Clear();
            lstOperaciones.Items.Add("Suma");
            lstOperaciones.Items.Add("Resta");
            lstOperaciones.Items.Add("Division");
            lstOperaciones.Items.Add("Multiplicacion");

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;

            n1 = double.Parse(txtNumber1.Text);
            n2 = Convert.ToDouble(txtNumber2.Text);

            if (lstOperaciones.SelectedIndex == 0) //suma
            {
                resultado = n1 + n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (lstOperaciones.SelectedIndex == 1) //Resta
            {
                resultado = n1 - n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (lstOperaciones.SelectedItem.Equals("Multiplicacion")) //Multiplicacion
            {
                resultado = n1 * n2;
                txtRespuesta.Text = Convert.ToString(resultado);
            }
            else if (lstOperaciones.SelectedItem.ToString() == "Division")//division
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    txtRespuesta.Text = string.Format("{0:n2}", (Math.Truncate(resultado * 100) / 100));
                }
                else
                {
                    MessageBox.Show("El valor del numero des debe ser distinto a cero...", "Operaciones Aritmeticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar la operacion...", "Operaciones Aritmeticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtRespuesta.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
