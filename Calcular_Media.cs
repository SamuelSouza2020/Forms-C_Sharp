using System;
using System.Windows.Forms;

namespace Calcular_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, resultado;
            num1 = Convert.ToDouble(txtNota1.Text);
            num2 = Convert.ToDouble(txtNota2.Text);
            num3 = Convert.ToDouble(txtNota3.Text);
            resultado = (num1 + num2 + num3) / 3;
            if(resultado < 5)
            {
                txtResultado.Text = resultado.ToString("N2") + " - REPROVADO";
            }
            else if(resultado >= 7)
            {
                txtResultado.Text = resultado.ToString("N2") + " - RECUPERAÇÃO";
            }
            else
            {
                txtResultado.Text = resultado.ToString("N2") + " - APROVADO";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtResultado.Text = "";
        }
    }
}
