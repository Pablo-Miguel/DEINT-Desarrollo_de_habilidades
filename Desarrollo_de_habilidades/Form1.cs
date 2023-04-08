namespace Desarrollo_de_habilidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double salarioTot = 0;
                double diffSalario = 0;
                double salarioNeto = Convert.ToDouble(tbSalario.Text);
                if (tbNombre.Text == "" || tbSalario.Text == "")
                {
                    MessageBox.Show("Introduzca datos en los campos requeridos");
                }
                else {
                    if (rbGerente.Checked)
                    {
                        salarioTot = salarioNeto * 0.80;
                        diffSalario = salarioNeto - salarioTot;
                        MessageBox.Show("[GERENTE] -> " + tbNombre.Text + ", Salario bruto: " + salarioNeto + "€, Salario neto (20%): " + salarioTot + "€, Diff: " + diffSalario + "€");
                    }
                    else if (rbSubGerente.Checked)
                    {
                        salarioTot = salarioNeto * 0.85;
                        diffSalario = salarioNeto - salarioTot;
                        MessageBox.Show("[SUBGERENTE] -> " + tbNombre.Text + ", Salario bruto: " + salarioNeto + "€, Salario neto (15%): " + salarioTot + "€, Diff: " + diffSalario + "€");
                    }
                    else if (rbSecretaria.Checked)
                    {
                        salarioTot = salarioNeto * 0.95;
                        diffSalario = salarioNeto - salarioTot;
                        MessageBox.Show("[SECRETARIA] -> " + tbNombre.Text + ", Salario bruto: " + salarioNeto + "€, Salario neto (5%): " + salarioTot + "€, Diff: " + diffSalario + "€");
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una de las opciones (Gerente, SubGerente o Secretaria)");
                    }
                }
            }
            catch(FormatException exception) {
                MessageBox.Show("El salario ha de ser conformado por números, no introducir ni letras ni símbolos", "ERROR: Salario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}