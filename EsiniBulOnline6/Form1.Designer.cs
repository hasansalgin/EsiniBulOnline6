namespace EsiniBulOnline6
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
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            yeniOyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(22, 42);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 600);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            gboYeniOyun.Location = new Point(159, 186);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(275, 268);
            gboYeniOyun.TabIndex = 1;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "yeni oyun";
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(95, 185);
            rb5.Name = "rb5";
            rb5.Size = new Size(74, 23);
            rb5.TabIndex = 5;
            rb5.Text = "çok zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(95, 149);
            rb4.Name = "rb4";
            rb4.Size = new Size(47, 23);
            rb4.TabIndex = 4;
            rb4.Text = "zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Location = new Point(95, 112);
            rb3.Name = "rb3";
            rb3.Size = new Size(54, 23);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(95, 75);
            rb2.Name = "rb2";
            rb2.Size = new Size(63, 23);
            rb2.TabIndex = 2;
            rb2.Text = "kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(95, 39);
            rb1.Name = "rb1";
            rb1.Size = new Size(90, 23);
            rb1.TabIndex = 1;
            rb1.Text = "çok kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOyunuBaslat.Location = new Point(36, 228);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(194, 30);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "OYUNU BAŞLAT";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(651, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            yeniOyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.Size = new Size(48, 20);
            yeniOyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(651, 673);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini bul oyunu";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private Button btnOyunuBaslat;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniOyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}