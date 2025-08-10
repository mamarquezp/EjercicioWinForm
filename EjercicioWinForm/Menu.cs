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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            HolaMundoMejorado cambioPantalla1 = new HolaMundoMejorado();
            cambioPantalla1.ShowDialog();
        }

        private void btnConversorTemperatura_Click(object sender, EventArgs e)
        {
            ConversorCelsius cambioPantalla2 = new ConversorCelsius();
            cambioPantalla2.ShowDialog();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora cambioPantalla3 = new Calculadora();
            cambioPantalla3.ShowDialog();
        }
    }
}
