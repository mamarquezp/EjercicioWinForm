
namespace EjercicioWinForm
{
    partial class HolaMundoMejorado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelHolaMundo = new Label();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // labelHolaMundo
            // 
            labelHolaMundo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelHolaMundo.AutoSize = true;
            labelHolaMundo.Location = new Point(0, 0);
            labelHolaMundo.Name = "labelHolaMundo";
            labelHolaMundo.Size = new Size(0, 20);
            labelHolaMundo.TabIndex = 0;
            labelHolaMundo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(120, 194);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(94, 29);
            btnSaludar.TabIndex = 1;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click_2;
            // 
            // HolaMundoMejorado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 299);
            Controls.Add(btnSaludar);
            Controls.Add(labelHolaMundo);
            Name = "HolaMundoMejorado";
            Text = "Hola Mundo Mejorado";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label labelHolaMundo;
        private Button btnSaludar;
    }
}
