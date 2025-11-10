namespace Casino
{
    partial class Profileend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profileend));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Vivaldi", 20F, FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 41);
            label1.TabIndex = 0;
            label1.Text = "Профіль";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(36, 89);
            button1.Name = "button1";
            button1.Size = new Size(230, 29);
            button1.TabIndex = 1;
            button1.Text = "Взяти кредит!!!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(676, 21);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(36, 143);
            button2.Name = "button2";
            button2.Size = new Size(230, 29);
            button2.TabIndex = 4;
            button2.Text = "Повернутись назад";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Profileend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Profileend";
            Text = "Profileend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}