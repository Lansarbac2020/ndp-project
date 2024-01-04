namespace kacisOyunu
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oyuncuİsmi = new System.Windows.Forms.TextBox();
            this.playerNmae = new System.Windows.Forms.Label();
            this.EnterButtonu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BilgiButtonu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HighScoreButton = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnterButtonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BilgiButtonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(971, 44);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 LtCn BT", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = " 2023-2024 GÜZ DÖNEMİ NDP proje Ödevi";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.ForeColor = System.Drawing.Color.Chartreuse;
            this.BottomPanel.Location = new System.Drawing.Point(0, 416);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(971, 34);
            this.BottomPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.oyuncuİsmi);
            this.panel1.Controls.Add(this.playerNmae);
            this.panel1.Location = new System.Drawing.Point(587, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 65);
            this.panel1.TabIndex = 4;
            // 
            // oyuncuİsmi
            // 
            this.oyuncuİsmi.Location = new System.Drawing.Point(128, 24);
            this.oyuncuİsmi.Name = "oyuncuİsmi";
            this.oyuncuİsmi.Size = new System.Drawing.Size(128, 20);
            this.oyuncuİsmi.TabIndex = 1;
            this.oyuncuİsmi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oyuncuİsmi_KeyDown);
            // 
            // playerNmae
            // 
            this.playerNmae.AutoSize = true;
            this.playerNmae.Location = new System.Drawing.Point(28, 27);
            this.playerNmae.Name = "playerNmae";
            this.playerNmae.Size = new System.Drawing.Size(65, 13);
            this.playerNmae.TabIndex = 0;
            this.playerNmae.Text = "Oyuncu Adi:";
            // 
            // EnterButtonu
            // 
            this.EnterButtonu.BackColor = System.Drawing.Color.Transparent;
            this.EnterButtonu.Image = ((System.Drawing.Image)(resources.GetObject("EnterButtonu.Image")));
            this.EnterButtonu.Location = new System.Drawing.Point(242, 248);
            this.EnterButtonu.Name = "EnterButtonu";
            this.EnterButtonu.Size = new System.Drawing.Size(37, 30);
            this.EnterButtonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnterButtonu.TabIndex = 5;
            this.EnterButtonu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oyuna baslamak icin bilgilerinizi giriniz ve\r\nEnter tuşuna basinz\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BilgiButtonu
            // 
            this.BilgiButtonu.BackColor = System.Drawing.Color.Transparent;
            this.BilgiButtonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BilgiButtonu.Image = ((System.Drawing.Image)(resources.GetObject("BilgiButtonu.Image")));
            this.BilgiButtonu.Location = new System.Drawing.Point(242, 300);
            this.BilgiButtonu.Name = "BilgiButtonu";
            this.BilgiButtonu.Size = new System.Drawing.Size(37, 35);
            this.BilgiButtonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BilgiButtonu.TabIndex = 7;
            this.BilgiButtonu.TabStop = false;
            this.BilgiButtonu.Click += new System.EventHandler(this.BilgiButtonu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oyun tuş takımı bilgisi almak için tıklayınız";
            // 
            // HighScoreButton
            // 
            this.HighScoreButton.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreButton.Image = ((System.Drawing.Image)(resources.GetObject("HighScoreButton.Image")));
            this.HighScoreButton.Location = new System.Drawing.Point(242, 351);
            this.HighScoreButton.Name = "HighScoreButton";
            this.HighScoreButton.Size = new System.Drawing.Size(37, 37);
            this.HighScoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HighScoreButton.TabIndex = 9;
            this.HighScoreButton.TabStop = false;
            this.HighScoreButton.Click += new System.EventHandler(this.HighScoreButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(299, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "En iyi skorları görüntülemek için tıklayınız";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HighScoreButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BilgiButtonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterButtonu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnterButtonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BilgiButtonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerNmae;
        private System.Windows.Forms.TextBox oyuncuİsmi;
        private System.Windows.Forms.PictureBox EnterButtonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BilgiButtonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox HighScoreButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

