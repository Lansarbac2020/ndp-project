namespace kacisOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BilgiPanel = new System.Windows.Forms.Panel();
            this.OyuncuAdi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LevelBtn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PuanLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KalanCan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GecenSure = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.TasBloklar = new System.Windows.Forms.Panel();
            this.BilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BilgiPanel
            // 
            this.BilgiPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BilgiPanel.Controls.Add(this.OyuncuAdi);
            this.BilgiPanel.Controls.Add(this.label8);
            this.BilgiPanel.Controls.Add(this.LevelBtn);
            this.BilgiPanel.Controls.Add(this.label6);
            this.BilgiPanel.Controls.Add(this.PuanLabel);
            this.BilgiPanel.Controls.Add(this.label4);
            this.BilgiPanel.Controls.Add(this.KalanCan);
            this.BilgiPanel.Controls.Add(this.label2);
            this.BilgiPanel.Controls.Add(this.GecenSure);
            this.BilgiPanel.Controls.Add(this.Timer);
            this.BilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BilgiPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.BilgiPanel.Name = "BilgiPanel";
            this.BilgiPanel.Size = new System.Drawing.Size(1191, 80);
            this.BilgiPanel.TabIndex = 0;
            this.BilgiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BilgiPanel_Paint);
            // 
            // OyuncuAdi
            // 
            this.OyuncuAdi.AutoSize = true;
            this.OyuncuAdi.Location = new System.Drawing.Point(934, 51);
            this.OyuncuAdi.Name = "OyuncuAdi";
            this.OyuncuAdi.Size = new System.Drawing.Size(0, 13);
            this.OyuncuAdi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(922, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "PlayerName";
            // 
            // LevelBtn
            // 
            this.LevelBtn.AutoSize = true;
            this.LevelBtn.Location = new System.Drawing.Point(664, 51);
            this.LevelBtn.Name = "LevelBtn";
            this.LevelBtn.Size = new System.Drawing.Size(14, 13);
            this.LevelBtn.TabIndex = 7;
            this.LevelBtn.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seviye";
            // 
            // PuanLabel
            // 
            this.PuanLabel.AutoSize = true;
            this.PuanLabel.Location = new System.Drawing.Point(457, 51);
            this.PuanLabel.Name = "PuanLabel";
            this.PuanLabel.Size = new System.Drawing.Size(21, 13);
            this.PuanLabel.TabIndex = 5;
            this.PuanLabel.Text = "00";
            this.PuanLabel.Click += new System.EventHandler(this.PuanLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puan1";
            // 
            // KalanCan
            // 
            this.KalanCan.AutoSize = true;
            this.KalanCan.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KalanCan.Location = new System.Drawing.Point(246, 49);
            this.KalanCan.Name = "KalanCan";
            this.KalanCan.Size = new System.Drawing.Size(20, 22);
            this.KalanCan.TabIndex = 3;
            this.KalanCan.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KalanCan";
            // 
            // GecenSure
            // 
            this.GecenSure.AutoSize = true;
            this.GecenSure.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GecenSure.Location = new System.Drawing.Point(46, 51);
            this.GecenSure.Name = "GecenSure";
            this.GecenSure.Size = new System.Drawing.Size(45, 19);
            this.GecenSure.TabIndex = 1;
            this.GecenSure.Text = "00:00";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(22, 26);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(97, 13);
            this.Timer.TabIndex = 0;
            this.Timer.Text = "Geçen Süre(Sn)";
            // 
            // TasBloklar
            // 
            this.TasBloklar.BackColor = System.Drawing.Color.Transparent;
            this.TasBloklar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TasBloklar.BackgroundImage")));
            this.TasBloklar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TasBloklar.Location = new System.Drawing.Point(500, 300);
            this.TasBloklar.Name = "TasBloklar";
            this.TasBloklar.Size = new System.Drawing.Size(600, 180);
            this.TasBloklar.TabIndex = 1;
            this.TasBloklar.Paint += new System.Windows.Forms.PaintEventHandler(this.TasBloklar_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 632);
            this.Controls.Add(this.BilgiPanel);
            this.Controls.Add(this.TasBloklar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BilgiPanel.ResumeLayout(false);
            this.BilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BilgiPanel;
        public System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GecenSure;
       public System.Windows.Forms.Label KalanCan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PuanLabel;
        private System.Windows.Forms.Label OyuncuAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LevelBtn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel TasBloklar;
    }
}