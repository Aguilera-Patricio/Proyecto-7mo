namespace TP3
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
            Titulo = new Label();
            caja2 = new TextBox();
            caja1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            result1 = new Label();
            result2 = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Bell MT", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Titulo.ImageAlign = ContentAlignment.TopCenter;
            Titulo.Location = new Point(261, 25);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(261, 37);
            Titulo.TabIndex = 0;
            Titulo.Text = "CALCULADORA";
            // 
            // caja2
            // 
            caja2.Location = new Point(266, 149);
            caja2.Name = "caja2";
            caja2.Size = new Size(331, 31);
            caja2.TabIndex = 10;
            // 
            // caja1
            // 
            caja1.Location = new Point(266, 107);
            caja1.Name = "caja1";
            caja1.Size = new Size(331, 31);
            caja1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(634, 125);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 148);
            label2.Name = "label2";
            label2.Size = new Size(252, 30);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el numero 'b' :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 106);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el numero 'a' :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(196, 240);
            label3.Name = "label3";
            label3.Size = new Size(317, 45);
            label3.TabIndex = 11;
            label3.Text = "(a + b) * (a - b) =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(196, 307);
            label4.Name = "label4";
            label4.Size = new Size(337, 45);
            label4.TabIndex = 12;
            label4.Text = "(a ^ 2) - (b ^ 2)  =";
            // 
            // result1
            // 
            result1.AutoSize = true;
            result1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            result1.Location = new Point(519, 240);
            result1.Name = "result1";
            result1.Size = new Size(155, 45);
            result1.TabIndex = 13;
            result1.Text = "#####";
            result1.Click += label3_Click;
            // 
            // result2
            // 
            result2.AutoSize = true;
            result2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            result2.Location = new Point(529, 307);
            result2.Name = "result2";
            result2.Size = new Size(155, 45);
            result2.TabIndex = 14;
            result2.Text = "#####";
            // 
            // Aguilera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 218, 158);
            ClientSize = new Size(800, 450);
            Controls.Add(result2);
            Controls.Add(result1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(caja2);
            Controls.Add(caja1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Name = "Aguilera";
            Text = "Aguilera - P";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox caja2;
        private TextBox caja1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label result1;
        private Label result2;
    }
}