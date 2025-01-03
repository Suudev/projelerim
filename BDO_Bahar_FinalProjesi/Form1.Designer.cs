namespace BDO_Bahar_FinalProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btniskelet = new System.Windows.Forms.Button();
            this.btnkas = new System.Windows.Forms.Button();
            this.btnicorganlar = new System.Windows.Forms.Button();
            this.btnduyuorganlari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(219, 99);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 323);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(736, 99);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 323);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btniskelet
            // 
            this.btniskelet.BackColor = System.Drawing.Color.DarkSalmon;
            this.btniskelet.Location = new System.Drawing.Point(11, 446);
            this.btniskelet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btniskelet.Name = "btniskelet";
            this.btniskelet.Size = new System.Drawing.Size(184, 46);
            this.btniskelet.TabIndex = 4;
            this.btniskelet.Text = "İskelet Sistemi";
            this.btniskelet.UseVisualStyleBackColor = false;
            this.btniskelet.Click += new System.EventHandler(this.btniskelet_Click);
            // 
            // btnkas
            // 
            this.btnkas.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnkas.Location = new System.Drawing.Point(229, 446);
            this.btnkas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkas.Name = "btnkas";
            this.btnkas.Size = new System.Drawing.Size(188, 46);
            this.btnkas.TabIndex = 5;
            this.btnkas.Text = "Kas Sistemi";
            this.btnkas.UseVisualStyleBackColor = false;
            this.btnkas.Click += new System.EventHandler(this.btnkas_Click);
            // 
            // btnicorganlar
            // 
            this.btnicorganlar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnicorganlar.Location = new System.Drawing.Point(471, 446);
            this.btnicorganlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnicorganlar.Name = "btnicorganlar";
            this.btnicorganlar.Size = new System.Drawing.Size(212, 46);
            this.btnicorganlar.TabIndex = 6;
            this.btnicorganlar.Text = "İç organlar";
            this.btnicorganlar.UseVisualStyleBackColor = false;
            this.btnicorganlar.Click += new System.EventHandler(this.btnicorganlar_Click);
            // 
            // btnduyuorganlari
            // 
            this.btnduyuorganlari.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnduyuorganlari.Location = new System.Drawing.Point(751, 446);
            this.btnduyuorganlari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnduyuorganlari.Name = "btnduyuorganlari";
            this.btnduyuorganlari.Size = new System.Drawing.Size(214, 46);
            this.btnduyuorganlari.TabIndex = 7;
            this.btnduyuorganlari.Text = "Duyu Organları";
            this.btnduyuorganlari.UseVisualStyleBackColor = false;
            this.btnduyuorganlari.Click += new System.EventHandler(this.btnduyuorganlari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(368, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dijital Kadavra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(344, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lütfen bilgi almak istediğiniz bölüme tıklayınız.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(450, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 323);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 562);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnduyuorganlari);
            this.Controls.Add(this.btnicorganlar);
            this.Controls.Add(this.btnkas);
            this.Controls.Add(this.btniskelet);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btniskelet;
        private System.Windows.Forms.Button btnkas;
        private System.Windows.Forms.Button btnicorganlar;
        private System.Windows.Forms.Button btnduyuorganlari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

