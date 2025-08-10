namespace EjercicioWinForm
{
    partial class ConversorCelsius
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
            components = new System.ComponentModel.Container();
            cmbBoxConversion = new ComboBox();
            btnConvertir = new Button();
            labelTemperatura = new Label();
            txtBoxTemperatura = new TextBox();
            errorProvider = new ErrorProvider(components);
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cmbBoxConversion
            // 
            cmbBoxConversion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxConversion.FormattingEnabled = true;
            cmbBoxConversion.Items.AddRange(new object[] { "Celsius a Fahrenheit", "Fahrenheit a Celsius" });
            cmbBoxConversion.Location = new Point(136, 59);
            cmbBoxConversion.Name = "cmbBoxConversion";
            cmbBoxConversion.Size = new Size(213, 28);
            cmbBoxConversion.TabIndex = 3;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(281, 295);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // labelTemperatura
            // 
            labelTemperatura.AutoSize = true;
            labelTemperatura.Location = new Point(12, 9);
            labelTemperatura.Name = "labelTemperatura";
            labelTemperatura.Size = new Size(93, 20);
            labelTemperatura.TabIndex = 1;
            labelTemperatura.Text = "Temperatura";
            // 
            // txtBoxTemperatura
            // 
            txtBoxTemperatura.Location = new Point(136, 9);
            txtBoxTemperatura.Name = "txtBoxTemperatura";
            txtBoxTemperatura.PlaceholderText = "Ingresa la temperatura";
            txtBoxTemperatura.Size = new Size(213, 27);
            txtBoxTemperatura.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(105, 150);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 4;
            labelError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConversorCelsius
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 336);
            Controls.Add(labelError);
            Controls.Add(cmbBoxConversion);
            Controls.Add(txtBoxTemperatura);
            Controls.Add(labelTemperatura);
            Controls.Add(btnConvertir);
            Name = "ConversorCelsius";
            Text = "ConversorCelsius";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label labelTemperatura;
        private TextBox txtBoxTemperatura;
        private ComboBox cmbBoxConversion;
        private ErrorProvider errorProvider;
        private Label labelError;
    }
}