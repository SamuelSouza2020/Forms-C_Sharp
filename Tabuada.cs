using System;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, resultado, i;
            i = 1;
            num = int.Parse(txtNumero.Text);
            while(i<=10)
            {
                resultado = i * num;
                lstTabuada.Items.Add(String.Concat(num, " * ", i, " = ", resultado));
                i++;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            txtNumero.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
