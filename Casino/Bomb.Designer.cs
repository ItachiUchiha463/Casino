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
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            textBox2 = new System.Windows.Forms.TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Showcard Gothic", 19.800001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.Location = new System.Drawing.Point(608, 419);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(309, 66);
            button1.TabIndex = 0;
            button1.Text = "Зробити ставку";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(86, 400);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(314, 23);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
            pictureBox1.Location = new System.Drawing.Point(127, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(383, 351);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Location = new System.Drawing.Point(12, 433);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(86, 40);
            button2.TabIndex = 4;
            button2.Text = "50";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.Location = new System.Drawing.Point(104, 433);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(86, 40);
            button3.TabIndex = 5;
            button3.Text = "100";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Yellow;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button4.Location = new System.Drawing.Point(196, 433);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(86, 40);
            button4.TabIndex = 6;
            button4.Text = "250";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Lime;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button5.Location = new System.Drawing.Point(288, 433);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(86, 40);
            button5.TabIndex = 7;
            button5.Text = "500";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Blue;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button6.Location = new System.Drawing.Point(380, 433);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(86, 40);
            button6.TabIndex = 8;
            button6.Text = "ALL IN";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tempus Sans ITC", 34.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 61);
            label1.TabIndex = 15;
            label1.Text = "ОКР";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(796, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 23);
            label2.TabIndex = 16;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.Blue;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button7.Location = new System.Drawing.Point(472, 433);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(86, 40);
            button7.TabIndex = 17;
            button7.Text = "Очистити";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(233, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(166, 43);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(620, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(284, 169);
            listBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(620, 390);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(284, 23);
            textBox2.TabIndex = 20;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(620, 323);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(283, 30);
            button8.TabIndex = 21;
            button8.Text = "Забрати";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Bomb
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            ClientSize = new System.Drawing.Size(929, 497);
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
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}