namespace TP5
{
    partial class Form1
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
            btnIniciar = new Button();
            etLabel = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(318, 335);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(125, 51);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // etLabel
            // 
            etLabel.AutoSize = true;
            etLabel.Font = new Font("Algerian", 72F, FontStyle.Bold, GraphicsUnit.Point);
            etLabel.Location = new Point(139, 98);
            etLabel.Name = "etLabel";
            etLabel.Size = new Size(496, 160);
            etLabel.TabIndex = 3;
            etLabel.Text = "Reloj";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 249, 196);
            ClientSize = new Size(811, 454);
            Controls.Add(etLabel);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Aguilera - P";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnIniciar;
        private Label etLabel;
    }
}