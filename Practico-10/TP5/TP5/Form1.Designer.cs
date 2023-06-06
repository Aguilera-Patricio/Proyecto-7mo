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
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            etLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnDetener = new Button();
            btnReiniciar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(152, 368);
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
            etLabel.Font = new Font("Algerian", 48F, FontStyle.Bold, GraphicsUnit.Point);
            etLabel.Location = new Point(134, 197);
            etLabel.Name = "etLabel";
            etLabel.Size = new Size(541, 106);
            etLabel.TabIndex = 3;
            etLabel.Text = "00 : 00 : 00";
            etLabel.Click += etLabel_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnDetener
            // 
            btnDetener.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetener.Location = new Point(340, 368);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(125, 51);
            btnDetener.TabIndex = 4;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(523, 368);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(125, 51);
            btnReiniciar.TabIndex = 5;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(152, 3);
            label2.Name = "label2";
            label2.Size = new Size(496, 160);
            label2.TabIndex = 6;
            label2.Text = "Reloj";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 249, 196);
            ClientSize = new Size(811, 454);
            Controls.Add(label2);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
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
        private System.Windows.Forms.Timer timer1;
        private Button btnDetener;
        private Button btnReiniciar;
        private Label label2;
    }
}