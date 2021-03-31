 //Bibliotecas
 using System;
 using System.Windows.forms;
 
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
                MessageBox.Show("Abaixo do Peso", "CUIDADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(resultado < 25)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Peso Normal";
                MessageBox.Show("Peso Normal","BOM", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if(resultado < 30)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Sobre Peso";
                MessageBox.Show("Acima do Peso", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(resultado < 35)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Obesidade 1";
                MessageBox.Show("Obesidade Nível 1", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(resultado < 40)
            {
                txtResultado.Text = resultado.ToString("N2") + " - Obesidade 2";
                MessageBox.Show("Obesidade Nível 2", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtResultado.Text = resultado.ToString("N2") + " - Obesidade Mórbida";
                MessageBox.Show("Obesidade Nível 3","CUIDADO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }