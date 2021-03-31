using System;
using System.Windows.Forms;

namespace Semana_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtResposta.Text = "";
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Primeiro dia da Semana","AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Primeiro Dia";
                    break;
                case "Segunda":
                    MessageBox.Show("Segundo dia da Semana", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Segundo Dia";
                    break;
                case "Terça":
                    MessageBox.Show("Terceiro dia da Semana", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Terceiro Dia";
                    break;
                case "Quarta":
                    MessageBox.Show("Quarto dia da Semana", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Quarto Dia";
                    break;
                case "Quinta":
                    MessageBox.Show("Quinto dia da Semana", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Quinto Dia";
                    break;
                case "Sexta":
                    MessageBox.Show("Sexto dia da Semana", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Sexto Dia";
                    break;
                case "Sábado":
                    MessageBox.Show("Sétimo dia da Semana", "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResposta.Text = "Sétimo Dia";
                    break;
            }
        }
    }
}
