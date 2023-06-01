namespace TP4
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
            label2 = new Label();
            enviar = new Button();
            caja1 = new TextBox();
            label3 = new Label();
            Vocal = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 47);
            label1.TabIndex = 0;
            label1.Text = "Vocal o No Vocal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(18, 129);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 1;
            label2.Text = "Ingrese una letra :";
            // 
            // enviar
            // 
            enviar.Font = new Font("Bernard MT Condensed", 11F, FontStyle.Italic, GraphicsUnit.Point);
            enviar.Location = new Point(640, 126);
            enviar.Name = "enviar";
            enviar.Size = new Size(112, 34);
            enviar.TabIndex = 2;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += enviar_Click;
            // 
            // caja1
            // 
            caja1.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            caja1.Location = new Point(235, 124);
            caja1.Name = "caja1";
            caja1.Size = new Size(370, 36);
            caja1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(167, 291);
            label3.Name = "label3";
            label3.Size = new Size(261, 38);
            label3.TabIndex = 4;
            label3.Text = "La Letra Ingresada :";
            // 
            // Vocal
            // 
            Vocal.AutoSize = true;
            Vocal.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Italic, GraphicsUnit.Point);
            Vocal.Location = new Point(434, 291);
            Vocal.Name = "Vocal";
            Vocal.Size = new Size(206, 38);
            Vocal.TabIndex = 5;
            Vocal.Text = "#########";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-9, 193);
            label4.Name = "label4";
            label4.Size = new Size(832, 45);
            label4.TabIndex = 6;
            label4.Text = "----------------------------------------------------------";
            // 
            // Aguilera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Vocal);
            Controls.Add(label3);
            Controls.Add(caja1);
            Controls.Add(enviar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Aguilera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aguilera - P";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button enviar;
        private TextBox caja1;
        private Label label3;
        private Label Vocal;
        private Label label4;
    }
}