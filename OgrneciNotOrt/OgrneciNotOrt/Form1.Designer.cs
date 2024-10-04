namespace OgrneciNotOrt
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
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 59);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "1.Sınav";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 108);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "2.Sınav";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 302);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "5.Sınav";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 225);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 7;
            label5.Text = "4. Sınav";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 167);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 8;
            label6.Text = "3. Sınav";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(313, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(313, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(131, 295);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(313, 27);
            textBox6.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(131, 356);
            button1.Name = "button1";
            button1.Size = new Size(313, 29);
            button1.TabIndex = 13;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(488, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(708, 364);
            listBox1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 411);
            label7.Name = "label7";
            label7.Size = new Size(309, 20);
            label7.TabIndex = 17;
            label7.Text = "Girdiğiniz Sayılar 0 ile 100 Arasında Olmalıdır";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 492);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ÖĞRENCİ NOT UYGULAMASI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private ListBox listBox1;
        private Label label7;
    }
}
