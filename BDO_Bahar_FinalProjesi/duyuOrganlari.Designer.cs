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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(297, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 475);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoz
            // 
            this.btnGoz.Location = new System.Drawing.Point(646, 139);
            this.btnGoz.Name = "btnGoz";
            this.btnGoz.Size = new System.Drawing.Size(85, 35);
            this.btnGoz.TabIndex = 4;
            this.btnGoz.Text = "Göz";
            this.btnGoz.UseVisualStyleBackColor = true;
            // 
            // btnKulak
            // 
            this.btnKulak.Location = new System.Drawing.Point(206, 150);
            this.btnKulak.Name = "btnKulak";
            this.btnKulak.Size = new System.Drawing.Size(85, 35);
            this.btnKulak.TabIndex = 5;
            this.btnKulak.Text = "Kulak";
            this.btnKulak.UseVisualStyleBackColor = true;
            // 
            // btnBurun
            // 
            this.btnBurun.Location = new System.Drawing.Point(206, 249);
            this.btnBurun.Name = "btnBurun";
            this.btnBurun.Size = new System.Drawing.Size(85, 35);
            this.btnBurun.TabIndex = 6;
            this.btnBurun.Text = "Burun";
            this.btnBurun.UseVisualStyleBackColor = true;
            // 
            // btnAgiz
            // 
            this.btnAgiz.Location = new System.Drawing.Point(206, 360);
            this.btnAgiz.Name = "btnAgiz";
            this.btnAgiz.Size = new System.Drawing.Size(85, 35);
            this.btnAgiz.TabIndex = 7;
            this.btnAgiz.Text = "Ağız";
            this.btnAgiz.UseVisualStyleBackColor = true;
            // 
            // btnDokunma
            // 
            this.btnDokunma.Location = new System.Drawing.Point(646, 259);
            this.btnDokunma.Name = "btnDokunma";
            this.btnDokunma.Size = new System.Drawing.Size(85, 35);
            this.btnDokunma.TabIndex = 8;
            this.btnDokunma.Text = "Dokunma";
            this.btnDokunma.UseVisualStyleBackColor = true;
            // 
            // duyuOrganlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 618);
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
    }
}