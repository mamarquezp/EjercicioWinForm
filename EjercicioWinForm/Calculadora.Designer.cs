namespace EjercicioWinForm
{
    partial class Calculadora
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
            txtBoxPrimerNumero = new TextBox();
            txtBoxSegundoNumero = new TextBox();
            labelResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnDivide = new Button();
            btnMultiplica = new Button();
            SuspendLayout();
            // 
            // txtBoxPrimerNumero
            // 
            txtBoxPrimerNumero.Location = new Point(12, 12);
            txtBoxPrimerNumero.Name = "txtBoxPrimerNumero";
            txtBoxPrimerNumero.PlaceholderText = "Ingrese un número";
            txtBoxPrimerNumero.Size = new Size(137, 27);
            txtBoxPrimerNumero.TabIndex = 1;
            // 
            // txtBoxSegundoNumero
            // 
            txtBoxSegundoNumero.Location = new Point(12, 57);
            txtBoxSegundoNumero.Name = "txtBoxSegundoNumero";
            txtBoxSegundoNumero.PlaceholderText = "Ingrese un número";
            txtBoxSegundoNumero.Size = new Size(137, 27);
            txtBoxSegundoNumero.TabIndex = 3;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(203, 33);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(36, 35);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "0";
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 10F);
            btnSuma.Location = new Point(12, 126);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(121, 83);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(192, 126);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(121, 83);
            btnResta.TabIndex = 6;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(192, 242);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(121, 83);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiplica
            // 
            btnMultiplica.Location = new Point(12, 242);
            btnMultiplica.Name = "btnMultiplica";
            btnMultiplica.Size = new Size(121, 83);
            btnMultiplica.TabIndex = 7;
            btnMultiplica.Text = "Multiplica";
            btnMultiplica.UseVisualStyleBackColor = true;
            btnMultiplica.Click += btnMultiplica_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 360);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiplica);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(labelResultado);
            Controls.Add(txtBoxSegundoNumero);
            Controls.Add(txtBoxPrimerNumero);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxPrimerNumero;
        private TextBox txtBoxSegundoNumero;
        private Label labelResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDivide;
        private Button btnMultiplica;
    }
}