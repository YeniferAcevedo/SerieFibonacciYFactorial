using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1Herencia
{
    public partial class Form1 : Form
    {
        Factorial factorial = new Factorial();
        Fibonacci fibonacci = new Fibonacci();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            factorial.setNumeroIngresado(long.Parse(txtNumeroIngresado.Text));
            lblResultadoFactorial.Visible = true;
            lblResultadoFactorial.Text = Convert.ToString(factorial.calcularFactorial());
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            fibonacci.setNumeroIngresado(long.Parse(txtNumeroIngresado.Text));

            foreach (long valores in fibonacci.calcularFibonacci())
            {
                ltbFibonacci.Items.Add(valores);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroIngresado.Text = string.Empty;
            lblResultadoFactorial.Text = "0";
            ltbFibonacci.Items.Clear();
            txtNumeroIngresado.Focus();
        }
    }
}
