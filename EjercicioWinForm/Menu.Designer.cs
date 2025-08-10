namespace EjercicioWinForm
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaludo = new Button();
            btnConversorTemperatura = new Button();
            btnCalculadora = new Button();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(12, 81);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(318, 113);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Hola Mundo Mejorado";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // btnConversorTemperatura
            // 
            btnConversorTemperatura.Location = new Point(12, 200);
            btnConversorTemperatura.Name = "btnConversorTemperatura";
            btnConversorTemperatura.Size = new Size(318, 113);
            btnConversorTemperatura.TabIndex = 1;
            btnConversorTemperatura.Text = "Conversor Temperatura";
            btnConversorTemperatura.UseVisualStyleBackColor = true;
            btnConversorTemperatura.Click += btnConversorTemperatura_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(12, 319);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(318, 113);
            btnCalculadora.TabIndex = 2;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(1, 29);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(342, 23);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Bienvenido a los ejercicios de WINFORMS";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(labelTitulo);
            Controls.Add(btnCalculadora);
            Controls.Add(btnConversorTemperatura);
            Controls.Add(btnSaludo);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private Button btnConversorTemperatura;
        private Button btnCalculadora;
        private Label labelTitulo;
    }
}