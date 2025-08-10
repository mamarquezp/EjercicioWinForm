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
    public partial class ConversorCelsius : Form

    {
        public ConversorCelsius()

        {
            InitializeComponent();
            ConfigurarInicio();
        }
        private void ConfigurarInicio()
        {
            cmbBoxConversion.SelectedIndex = 0;
            txtBoxTemperatura.Validating += TxtBoxTemperatura_Validating;
        }

        private void TxtBoxTemperatura_Validating(object sender, CancelEventArgs e)
        {
            var temperaturaTexto = txtBoxTemperatura.Text;
            if (string.IsNullOrWhiteSpace(temperaturaTexto) || !double.TryParse(temperaturaTexto, out _))
            {
                errorProvider.SetError(txtBoxTemperatura, "Debe ingresar un valor numérico.");
                btnConvertir.Enabled = false;
                labelError.Text = "Debe ingresar un valor numérico";
                e.Cancel = true;
               
            }
            else
            {
                errorProvider.SetError(txtBoxTemperatura, "");
                btnConvertir.Enabled = true;
                labelError.Text = "";
                e.Cancel= false;
            }
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }            
            double temperatura = double.Parse(txtBoxTemperatura.Text);
            double resultado;
            string mensaje;

            if (cmbBoxConversion.SelectedIndex == 0)
            {
                resultado = (temperatura * 9.0 / 5.0) + 32;
                mensaje = $"{temperatura}°C equivale a {resultado:F2}°F";
            }
            else
            {
                resultado = (temperatura - 32) * 5.0 / 9.0;
                mensaje = $"{temperatura}°F equivale a {resultado:F2}°C";
            }

            MessageBox.Show(mensaje, "Resultado de la Conversión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
