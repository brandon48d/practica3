namespace practica3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 115);
            label1.Name = "label1";
            label1.Size = new Size(145, 34);
            label1.TabIndex = 0;
            label1.Text = "Primer numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 181);
            label2.Name = "label2";
            label2.Size = new Size(157, 34);
            label2.TabIndex = 2;
            label2.Text = "Segundo numero";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 255);
            label3.Name = "label3";
            label3.Size = new Size(65, 34);
            label3.TabIndex = 4;
            label3.Text = "Sum=";
            // 
            // button1
            // 
            button1.Font = new Font("Humnst777 Blk BT", 24F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(243, 321);
            button1.Name = "button1";
            button1.Size = new Size(200, 68);
            button1.TabIndex = 5;
            button1.Text = "Sumar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1371, 600);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Sumar Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}