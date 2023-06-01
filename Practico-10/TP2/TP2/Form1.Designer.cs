namespace TP2
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
            button1 = new Button();
            caja1 = new TextBox();
            Titulo = new Label();
            caja2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Mult = new Label();
            Division = new Label();
            Resta = new Label();
            Suma = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 109);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el numero 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1, 151);
            label2.Name = "label2";
            label2.Size = new Size(234, 30);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el numero 2 :";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(613, 124);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // caja1
            // 
            caja1.Location = new Point(245, 110);
            caja1.Name = "caja1";
            caja1.Size = new Size(331, 31);
            caja1.TabIndex = 3;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Bell MT", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Titulo.Location = new Point(279, 24);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(261, 37);
            Titulo.TabIndex = 4;
            Titulo.Text = "CALCULADORA";
            // 
            // caja2
            // 
            caja2.Location = new Point(245, 152);
            caja2.Name = "caja2";
            caja2.Size = new Size(331, 31);
            caja2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 246);
            label6.Name = "label6";
            label6.Size = new Size(118, 39);
            label6.TabIndex = 6;
            label6.Text = "Suma =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 351);
            label5.Name = "label5";
            label5.Size = new Size(123, 39);
            label5.TabIndex = 7;
            label5.Text = "Resta =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(403, 351);
            label4.Name = "label4";
            label4.Size = new Size(148, 39);
            label4.TabIndex = 8;
            label4.Text = "División =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(403, 246);
            label3.Name = "label3";
            label3.Size = new Size(228, 39);
            label3.TabIndex = 9;
            label3.Text = "Multiplicación =";
            // 
            // Mult
            // 
            Mult.AutoSize = true;
            Mult.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Mult.Location = new Point(627, 246);
            Mult.Name = "Mult";
            Mult.Size = new Size(113, 39);
            Mult.TabIndex = 13;
            Mult.Text = "####";
            // 
            // Division
            // 
            Division.AutoSize = true;
            Division.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Division.Location = new Point(540, 351);
            Division.Name = "Division";
            Division.Size = new Size(161, 39);
            Division.TabIndex = 12;
            Division.Text = "######";
            Division.Click += label4_Click;
            // 
            // Resta
            // 
            Resta.AutoSize = true;
            Resta.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Resta.Location = new Point(165, 351);
            Resta.Name = "Resta";
            Resta.Size = new Size(161, 39);
            Resta.TabIndex = 11;
            Resta.Text = "######";
            // 
            // Suma
            // 
            Suma.AutoSize = true;
            Suma.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Suma.Location = new Point(165, 246);
            Suma.Name = "Suma";
            Suma.Size = new Size(161, 39);
            Suma.TabIndex = 10;
            Suma.Text = "######";
            // 
            // Aguilera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(Mult);
            Controls.Add(Division);
            Controls.Add(Resta);
            Controls.Add(Suma);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(caja2);
            Controls.Add(Titulo);
            Controls.Add(caja1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Aguilera";
            Text = "Aguilera - P";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox caja1;
        private Label Titulo;
        private TextBox caja2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Mult;
        private Label Division;
        private Label Resta;
        private Label Suma;
    }
}