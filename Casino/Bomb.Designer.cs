namespace Casino
{
    partial class Bomb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bomb));
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 12.8000011F);
            button1.Location = new Point(695, 559);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 91);
            button1.TabIndex = 0;
            button1.Text = "Зробити ставку";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(98, 533);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(358, 41);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 57);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(14, 577);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(98, 53);
            button2.TabIndex = 4;
            button2.Text = "50";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Showcard Gothic", 13.8F);
            button3.Location = new Point(119, 577);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(98, 53);
            button3.TabIndex = 5;
            button3.Text = "100";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Showcard Gothic", 13.8F);
            button4.Location = new Point(224, 577);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(98, 53);
            button4.TabIndex = 6;
            button4.Text = "250";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Showcard Gothic", 13.8F);
            button5.Location = new Point(329, 577);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(98, 53);
            button5.TabIndex = 7;
            button5.Text = "500";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Blue;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Showcard Gothic", 13.8F);
            button6.Location = new Point(434, 577);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(98, 53);
            button6.TabIndex = 8;
            button6.Text = "ALL IN";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 34.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(164, 76);
            label1.TabIndex = 15;
            label1.Text = "ОКР";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(910, 12);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 16;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Blue;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(539, 577);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(98, 53);
            button7.TabIndex = 17;
            button7.Text = "Очистити";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(266, 248);
            label3.Name = "label3";
            label3.Size = new Size(190, 57);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(709, 79);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(324, 224);
            listBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(709, 520);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(324, 27);
            textBox2.TabIndex = 20;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.Font = new Font("Segoe UI", 14F);
            button8.Location = new Point(869, 559);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(161, 91);
            button8.TabIndex = 21;
            button8.Text = "Забрати";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(710, 362);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(323, 40);
            button9.TabIndex = 22;
            button9.Text = "Повернуться назад";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Bomb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1042, 663);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Bomb";
            Text = "Bomb";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button8;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Label label3;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Button button7;
        private ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Button button9;
    }
}