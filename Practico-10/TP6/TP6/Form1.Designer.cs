namespace TP6
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
            enviar = new Button();
            label4 = new Label();
            Cd = new Label();
            label3 = new Label();
            caja1 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // enviar
            // 
            enviar.Font = new Font("Bernard MT Condensed", 10F, FontStyle.Italic, GraphicsUnit.Point);
            enviar.Location = new Point(671, 155);
            enviar.Name = "enviar";
            enviar.Size = new Size(112, 34);
            enviar.TabIndex = 30;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += enviar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-16, 248);
            label4.Name = "label4";
            label4.Size = new Size(829, 40);
            label4.TabIndex = 29;
            label4.Text = "----------------------------------------------------------";
            label4.Click += label4_Click;
            // 
            // Cd
            // 
            Cd.AutoSize = true;
            Cd.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Italic, GraphicsUnit.Point);
            Cd.Location = new Point(673, 360);
            Cd.Name = "Cd";
            Cd.Size = new Size(101, 38);
            Cd.TabIndex = 28;
            Cd.Text = "####";
            Cd.Click += Cd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(2, 360);
            label3.Name = "label3";
            label3.Size = new Size(665, 38);
            label3.TabIndex = 27;
            label3.Text = "La cantidad de CDs necesarios para  el respaldo son :";
            label3.Click += label3_Click;
            // 
            // caja1
            // 
            caja1.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            caja1.Location = new Point(444, 158);
            caja1.Name = "caja1";
            caja1.Size = new Size(209, 36);
            caja1.TabIndex = 26;
            caja1.TextChanged += caja1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(16, 161);
            label2.Name = "label2";
            label2.Size = new Size(422, 28);
            label2.TabIndex = 25;
            label2.Text = "Ingrese la capacidad del Disco Duro en GB :";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bernard MT Condensed", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(240, 42);
            label5.Name = "label5";
            label5.Size = new Size(349, 47);
            label5.TabIndex = 24;
            label5.Text = "De Disco Rigido a CDs";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 76);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 210, 234);
            ClientSize = new Size(800, 450);
            Controls.Add(enviar);
            Controls.Add(label4);
            Controls.Add(Cd);
            Controls.Add(label3);
            Controls.Add(caja1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aguilera - P";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enviar;
        private Label label4;
        private Label Cd;
        private Label label3;
        private TextBox caja1;
        private Label label2;
        private Label label5;
        private Label label1;
    }
}