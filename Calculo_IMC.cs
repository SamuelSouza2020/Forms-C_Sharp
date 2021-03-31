using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtResultado.Text = "";
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtPeso.Text);
            num2 = Convert.ToDouble(txtAltura.Text);
            resultado = num1 / (num2 * num2);
            if(resultado < 18.5)
            {
                txtResultado.Text = resultado.ToString("0.00") + " - Abaixo do Peso";
                MessageBox.Show("Cuidado, está abaixo", "Saco de Osso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(resultado < 25)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Peso Normal";
                MessageBox.Show("Excelente","Perfect", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if(resultado < 30)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Sobre Peso";
                MessageBox.Show("Comendo Muito", "Está Inchando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(resultado < 35)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Obesidade 1";
                MessageBox.Show("Comeu todo Estoque", "Super Bola", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(resultado < 40)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Obesidade 2";
                MessageBox.Show("Comeu todos alimentos da Cidade", "Gordao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtResultado.Text = resultado.ToString("N2") + " - Obesidade Mórbida";
                MessageBox.Show("Comeu toda comida do País","Novo Planeta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
