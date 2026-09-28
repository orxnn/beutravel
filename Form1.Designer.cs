namespace TravelTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            textBox1 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button3 = new Button();
            button4 = new Button();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 126);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(848, 126);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(41, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 300);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marşrut";
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Location = new Point(245, 38);
            button1.Name = "button1";
            button1.Size = new Size(67, 89);
            button1.TabIndex = 10;
            button1.Text = "<\r\n>";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(81, 201);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(131, 27);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(81, 152);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(131, 27);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(81, 247);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(81, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 28);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Seçin";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Seçin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 254);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 4;
            label5.Text = "Yer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 204);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 155);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarix:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Haraya:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(469, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 300);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sərnişin Məlumatları";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-422, -61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.Location = new Point(191, 247);
            button2.Name = "button2";
            button2.Size = new Size(113, 34);
            button2.TabIndex = 11;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 10;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(121, 197);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(131, 27);
            maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(121, 139);
            maskedTextBox4.Mask = "(999)-00-000-00-00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(131, 27);
            maskedTextBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(121, 85);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(131, 28);
            comboBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 204);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 3;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 146);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 2;
            label8.Text = "Telefon:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 93);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 1;
            label9.Text = "FİN kod:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 38);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 0;
            label10.Text = "Ad və soyad:";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(12, 588);
            button3.Name = "button3";
            button3.Size = new Size(139, 35);
            button3.TabIndex = 11;
            button3.Text = "Siyahıdan sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.ForeColor = Color.White;
            button4.Location = new Point(652, 588);
            button4.Name = "button4";
            button4.Size = new Size(199, 35);
            button4.TabIndex = 12;
            button4.Text = "Proqramdan çıxış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Pink;
            label11.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(415, 46);
            label11.Name = "label11";
            label11.Size = new Size(252, 50);
            label11.TabIndex = 14;
            label11.Text = "BMU TRAVEL";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(687, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 629);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BMU Travel";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private ComboBox comboBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
