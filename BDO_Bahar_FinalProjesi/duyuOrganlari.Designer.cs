namespace BDO_Bahar_FinalProjesi
{
    partial class duyuOrganlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(duyuOrganlari));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoz = new System.Windows.Forms.Button();
            this.btnKulak = new System.Windows.Forms.Button();
            this.btnBurun = new System.Windows.Forms.Button();
            this.btnAgiz = new System.Windows.Forms.Button();
            this.btnDokunma = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 475);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoz
            // 
            this.btnGoz.Location = new System.Drawing.Point(327, 101);
            this.btnGoz.Name = "btnGoz";
            this.btnGoz.Size = new System.Drawing.Size(85, 35);
            this.btnGoz.TabIndex = 4;
            this.btnGoz.Text = "Göz";
            this.btnGoz.UseVisualStyleBackColor = true;
            this.btnGoz.Click += new System.EventHandler(this.btnGoz_Click);
            // 
            // btnKulak
            // 
            this.btnKulak.Location = new System.Drawing.Point(2, 101);
            this.btnKulak.Name = "btnKulak";
            this.btnKulak.Size = new System.Drawing.Size(85, 35);
            this.btnKulak.TabIndex = 5;
            this.btnKulak.Text = "Kulak";
            this.btnKulak.UseVisualStyleBackColor = true;
            this.btnKulak.Click += new System.EventHandler(this.btnKulak_Click);
            // 
            // btnBurun
            // 
            this.btnBurun.Location = new System.Drawing.Point(2, 200);
            this.btnBurun.Name = "btnBurun";
            this.btnBurun.Size = new System.Drawing.Size(85, 35);
            this.btnBurun.TabIndex = 6;
            this.btnBurun.Text = "Burun";
            this.btnBurun.UseVisualStyleBackColor = true;
            this.btnBurun.Click += new System.EventHandler(this.btnBurun_Click);
            // 
            // btnAgiz
            // 
            this.btnAgiz.Location = new System.Drawing.Point(15, 313);
            this.btnAgiz.Name = "btnAgiz";
            this.btnAgiz.Size = new System.Drawing.Size(85, 35);
            this.btnAgiz.TabIndex = 7;
            this.btnAgiz.Text = "Ağız";
            this.btnAgiz.UseVisualStyleBackColor = true;
            this.btnAgiz.Click += new System.EventHandler(this.btnAgiz_Click);
            // 
            // btnDokunma
            // 
            this.btnDokunma.Location = new System.Drawing.Point(367, 200);
            this.btnDokunma.Name = "btnDokunma";
            this.btnDokunma.Size = new System.Drawing.Size(85, 35);
            this.btnDokunma.TabIndex = 8;
            this.btnDokunma.Text = "Dokunma";
            this.btnDokunma.UseVisualStyleBackColor = true;
            this.btnDokunma.Click += new System.EventHandler(this.btnDokunma_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnaMenu.Location = new System.Drawing.Point(367, 445);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(104, 42);
            this.btnAnaMenu.TabIndex = 19;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // duyuOrganlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 490);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnDokunma);
            this.Controls.Add(this.btnAgiz);
            this.Controls.Add(this.btnBurun);
            this.Controls.Add(this.btnKulak);
            this.Controls.Add(this.btnGoz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "duyuOrganlari";
            this.Text = "duyuOrganlari";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGoz;
        private System.Windows.Forms.Button btnKulak;
        private System.Windows.Forms.Button btnBurun;
        private System.Windows.Forms.Button btnAgiz;
        private System.Windows.Forms.Button btnDokunma;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}