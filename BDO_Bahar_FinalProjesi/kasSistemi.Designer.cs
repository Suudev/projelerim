﻿namespace BDO_Bahar_FinalProjesi
{
    partial class kasSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasSistemi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKafa = new System.Windows.Forms.Button();
            this.btnKol = new System.Windows.Forms.Button();
            this.btnGovde = new System.Windows.Forms.Button();
            this.btnBacak = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 548);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnKafa
            // 
            this.btnKafa.Location = new System.Drawing.Point(373, 43);
            this.btnKafa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKafa.Name = "btnKafa";
            this.btnKafa.Size = new System.Drawing.Size(64, 28);
            this.btnKafa.TabIndex = 2;
            this.btnKafa.Text = "Kafa";
            this.btnKafa.UseVisualStyleBackColor = true;
            this.btnKafa.Click += new System.EventHandler(this.btnKafa_Click);
            // 
            // btnKol
            // 
            this.btnKol.Location = new System.Drawing.Point(373, 158);
            this.btnKol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKol.Name = "btnKol";
            this.btnKol.Size = new System.Drawing.Size(64, 28);
            this.btnKol.TabIndex = 3;
            this.btnKol.Text = "Kol";
            this.btnKol.UseVisualStyleBackColor = true;
            this.btnKol.Click += new System.EventHandler(this.btnKol_Click);
            // 
            // btnGovde
            // 
            this.btnGovde.Location = new System.Drawing.Point(373, 298);
            this.btnGovde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGovde.Name = "btnGovde";
            this.btnGovde.Size = new System.Drawing.Size(64, 28);
            this.btnGovde.TabIndex = 4;
            this.btnGovde.Text = "Gövde";
            this.btnGovde.UseVisualStyleBackColor = true;
            this.btnGovde.Click += new System.EventHandler(this.btnGovde_Click);
            // 
            // btnBacak
            // 
            this.btnBacak.Location = new System.Drawing.Point(373, 406);
            this.btnBacak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBacak.Name = "btnBacak";
            this.btnBacak.Size = new System.Drawing.Size(64, 28);
            this.btnBacak.TabIndex = 5;
            this.btnBacak.Text = "Bacak";
            this.btnBacak.UseVisualStyleBackColor = true;
            this.btnBacak.Click += new System.EventHandler(this.btnBacak_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnaMenu.Location = new System.Drawing.Point(413, 514);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(78, 34);
            this.btnAnaMenu.TabIndex = 19;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // kasSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 544);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnBacak);
            this.Controls.Add(this.btnGovde);
            this.Controls.Add(this.btnKol);
            this.Controls.Add(this.btnKafa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "kasSistemi";
            this.Text = "kasSistemi";
            this.Load += new System.EventHandler(this.kasSistemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKafa;
        private System.Windows.Forms.Button btnKol;
        private System.Windows.Forms.Button btnGovde;
        private System.Windows.Forms.Button btnBacak;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}