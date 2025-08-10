using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWinForm
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPrimerNumero.Text) || !double.TryParse(txtBoxPrimerNumero.Text, out _) || string.IsNullOrWhiteSpace(txtBoxSegundoNumero.Text) || !double.TryParse(txtBoxSegundoNumero.Text, out _))
            {
                MessageBox.Show("Debe ingresar dos valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double primerNumero = double.Parse(txtBoxPrimerNumero.Text);
            double segundoNumero = double.Parse(txtBoxSegundoNumero.Text);
            double suma = Math.Round((primerNumero + segundoNumero), 2);
            labelResultado.Text = suma.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPrimerNumero.Text) || !double.TryParse(txtBoxPrimerNumero.Text, out _) || string.IsNullOrWhiteSpace(txtBoxSegundoNumero.Text) || !double.TryParse(txtBoxSegundoNumero.Text, out _))
            {
                MessageBox.Show("Debe ingresar dos valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double primerNumero = double.Parse(txtBoxPrimerNumero.Text);
            double segundoNumero = double.Parse(txtBoxSegundoNumero.Text);
            double resta = Math.Round((primerNumero - segundoNumero), 2);
            labelResultado.Text = resta.ToString();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPrimerNumero.Text) || !double.TryParse(txtBoxPrimerNumero.Text, out _) || string.IsNullOrWhiteSpace(txtBoxSegundoNumero.Text) || !double.TryParse(txtBoxSegundoNumero.Text, out _))
            {
                MessageBox.Show("Debe ingresar dos valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double primerNumero = double.Parse(txtBoxPrimerNumero.Text);
            double segundoNumero = double.Parse(txtBoxSegundoNumero.Text);
            double multiplica = Math.Round((primerNumero * segundoNumero), 2);
            labelResultado.Text = multiplica.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPrimerNumero.Text) || !double.TryParse(txtBoxPrimerNumero.Text, out _) || string.IsNullOrWhiteSpace(txtBoxSegundoNumero.Text) || !double.TryParse(txtBoxSegundoNumero.Text, out _))
            {
                MessageBox.Show("Debe ingresar dos valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double primerNumero = double.Parse(txtBoxPrimerNumero.Text);
            double segundoNumero = double.Parse(txtBoxSegundoNumero.Text);
            if (segundoNumero == 0)
            {
                MessageBox.Show("La división entre 0 no está definida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            double divide = Math.Round((primerNumero / segundoNumero), 2);
            labelResultado.Text = divide.ToString();
        }
    }
}
