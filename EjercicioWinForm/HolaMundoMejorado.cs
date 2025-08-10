namespace EjercicioWinForm
{
    public partial class HolaMundoMejorado : Form
    {
        public HolaMundoMejorado()
        {
            InitializeComponent();
        }
        private void btnSaludar_Click_2(object sender, EventArgs e)
        {
            labelHolaMundo.Text = "Hola, WinForms!";
            btnSaludar.Enabled = false;
        }
    }
}
