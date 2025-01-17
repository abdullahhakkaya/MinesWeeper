namespace MinesWeeper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SkorButton = new System.Windows.Forms.Button();
            this.BayrakLabel = new System.Windows.Forms.Label();
            this.SayacLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.MayinLabel = new System.Windows.Forms.Label();
            this.MayinTextBox = new System.Windows.Forms.TextBox();
            this.HücreLabel = new System.Windows.Forms.Label();
            this.HücreTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciAdiLabel = new System.Windows.Forms.Label();
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SkorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(470, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "BASLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SkorLabel);
            this.panel1.Controls.Add(this.SkorButton);
            this.panel1.Controls.Add(this.BayrakLabel);
            this.panel1.Controls.Add(this.SayacLabel);
            this.panel1.Controls.Add(this.sureLabel);
            this.panel1.Controls.Add(this.MayinLabel);
            this.panel1.Controls.Add(this.MayinTextBox);
            this.panel1.Controls.Add(this.HücreLabel);
            this.panel1.Controls.Add(this.HücreTextBox);
            this.panel1.Controls.Add(this.KullaniciAdiLabel);
            this.panel1.Controls.Add(this.KullaniciAdiTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 138);
            this.panel1.TabIndex = 1;
            // 
            // SkorButton
            // 
            this.SkorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SkorButton.Location = new System.Drawing.Point(579, 3);
            this.SkorButton.Name = "SkorButton";
            this.SkorButton.Size = new System.Drawing.Size(152, 74);
            this.SkorButton.TabIndex = 10;
            this.SkorButton.Text = "SKOR\r\nTABLOSU";
            this.SkorButton.UseVisualStyleBackColor = false;
            this.SkorButton.Click += new System.EventHandler(this.SkorButton_Click);
            // 
            // BayrakLabel
            // 
            this.BayrakLabel.AutoSize = true;
            this.BayrakLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BayrakLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BayrakLabel.Location = new System.Drawing.Point(130, 90);
            this.BayrakLabel.Name = "BayrakLabel";
            this.BayrakLabel.Size = new System.Drawing.Size(91, 38);
            this.BayrakLabel.TabIndex = 9;
            this.BayrakLabel.Text = "Bayr";
            // 
            // SayacLabel
            // 
            this.SayacLabel.AutoSize = true;
            this.SayacLabel.BackColor = System.Drawing.Color.Silver;
            this.SayacLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayacLabel.Location = new System.Drawing.Point(251, 90);
            this.SayacLabel.Name = "SayacLabel";
            this.SayacLabel.Size = new System.Drawing.Size(128, 38);
            this.SayacLabel.TabIndex = 8;
            this.SayacLabel.Text = "HAMLE";
            // 
            // sureLabel
            // 
            this.sureLabel.AutoSize = true;
            this.sureLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sureLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.Location = new System.Drawing.Point(20, 90);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(92, 38);
            this.sureLabel.TabIndex = 6;
            this.sureLabel.Text = "Süre";
            // 
            // MayinLabel
            // 
            this.MayinLabel.AutoSize = true;
            this.MayinLabel.Location = new System.Drawing.Point(388, 6);
            this.MayinLabel.Name = "MayinLabel";
            this.MayinLabel.Size = new System.Drawing.Size(76, 25);
            this.MayinLabel.TabIndex = 5;
            this.MayinLabel.Text = "Mayın:";
            // 
            // MayinTextBox
            // 
            this.MayinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayinTextBox.Location = new System.Drawing.Point(393, 36);
            this.MayinTextBox.Name = "MayinTextBox";
            this.MayinTextBox.Size = new System.Drawing.Size(60, 38);
            this.MayinTextBox.TabIndex = 4;
            // 
            // HücreLabel
            // 
            this.HücreLabel.AutoSize = true;
            this.HücreLabel.Location = new System.Drawing.Point(304, 6);
            this.HücreLabel.Name = "HücreLabel";
            this.HücreLabel.Size = new System.Drawing.Size(75, 25);
            this.HücreLabel.TabIndex = 3;
            this.HücreLabel.Text = "Hücre:";
            // 
            // HücreTextBox
            // 
            this.HücreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HücreTextBox.Location = new System.Drawing.Point(312, 36);
            this.HücreTextBox.Name = "HücreTextBox";
            this.HücreTextBox.Size = new System.Drawing.Size(67, 38);
            this.HücreTextBox.TabIndex = 2;
            // 
            // KullaniciAdiLabel
            // 
            this.KullaniciAdiLabel.AutoSize = true;
            this.KullaniciAdiLabel.Location = new System.Drawing.Point(85, 8);
            this.KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            this.KullaniciAdiLabel.Size = new System.Drawing.Size(136, 25);
            this.KullaniciAdiLabel.TabIndex = 2;
            this.KullaniciAdiLabel.Text = "Kullanıcı Adı:";
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(10, 36);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(284, 38);
            this.KullaniciAdiTextBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SkorLabel
            // 
            this.SkorLabel.AutoSize = true;
            this.SkorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SkorLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkorLabel.Location = new System.Drawing.Point(489, 90);
            this.SkorLabel.Name = "SkorLabel";
            this.SkorLabel.Size = new System.Drawing.Size(145, 38);
            this.SkorLabel.TabIndex = 11;
            this.SkorLabel.Text = "SKOR : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 140);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 734);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Abdullah Akkaya | 210229042";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HücreLabel;
        public System.Windows.Forms.TextBox HücreTextBox;
        private System.Windows.Forms.Label KullaniciAdiLabel;
        public System.Windows.Forms.TextBox KullaniciAdiTextBox;
        public System.Windows.Forms.TextBox MayinTextBox;
        private System.Windows.Forms.Label MayinLabel;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sureLabel;
        public System.Windows.Forms.Label SayacLabel;
        public System.Windows.Forms.Label BayrakLabel;
        private System.Windows.Forms.Button SkorButton;
        public System.Windows.Forms.Label SkorLabel;
        public System.Windows.Forms.Panel panel2;
    }
}

