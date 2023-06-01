namespace TP1
{
    partial class Aguilera
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
            label1 = new Label();
            caja = new TextBox();
            Enviar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(263, 38);
            label1.Name = "label1";
            label1.Size = new Size(291, 35);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su Nombre";
            label1.Click += label1_Click;
            // 
            // caja
            // 
            caja.Location = new Point(307, 104);
            caja.Name = "caja";
            caja.Size = new Size(207, 31);
            caja.TabIndex = 1;
            caja.TextChanged += caja_TextChanged;
            // 
            // Enviar
            // 
            Enviar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Enviar.Location = new Point(351, 164);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(112, 34);
            Enviar.TabIndex = 2;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(3, 269);
            label2.Name = "label2";
            label2.Size = new Size(0, 50);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Aguilera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Enviar);
            Controls.Add(caja);
            Controls.Add(label1);
            Name = "Aguilera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aguilera-P";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox caja;
        private Button Enviar;
        private Label label2;
    }
}