namespace BDO_Bahar_FinalProjesi
{
    partial class iskeletSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iskeletSistemi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKafa = new System.Windows.Forms.Button();
            this.btnKol = new System.Windows.Forms.Button();
            this.btnGovde = new System.Windows.Forms.Button();
            this.btnBacak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(234, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 414);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKafa
            // 
            this.btnKafa.Location = new System.Drawing.Point(455, 53);
            this.btnKafa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKafa.Name = "btnKafa";
            this.btnKafa.Size = new System.Drawing.Size(64, 28);
            this.btnKafa.TabIndex = 1;
            this.btnKafa.Text = "Kafa";
            this.btnKafa.UseVisualStyleBackColor = true;
            this.btnKafa.Click += new System.EventHandler(this.btnKafa_Click);
            // 
            // btnKol
            // 
            this.btnKol.Location = new System.Drawing.Point(166, 151);
            this.btnKol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKol.Name = "btnKol";
            this.btnKol.Size = new System.Drawing.Size(64, 28);
            this.btnKol.TabIndex = 2;
            this.btnKol.Text = "Kol";
            this.btnKol.UseVisualStyleBackColor = true;
            // 
            // btnGovde
            // 
            this.btnGovde.Location = new System.Drawing.Point(455, 195);
            this.btnGovde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGovde.Name = "btnGovde";
            this.btnGovde.Size = new System.Drawing.Size(64, 28);
            this.btnGovde.TabIndex = 3;
            this.btnGovde.Text = "Gövde";
            this.btnGovde.UseVisualStyleBackColor = true;
            // 
            // btnBacak
            // 
            this.btnBacak.Location = new System.Drawing.Point(166, 342);
            this.btnBacak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBacak.Name = "btnBacak";
            this.btnBacak.Size = new System.Drawing.Size(64, 28);
            this.btnBacak.TabIndex = 4;
            this.btnBacak.Text = "Bacak";
            this.btnBacak.UseVisualStyleBackColor = true;
            // 
            // iskeletSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 502);
            this.Controls.Add(this.btnBacak);
            this.Controls.Add(this.btnGovde);
            this.Controls.Add(this.btnKol);
            this.Controls.Add(this.btnKafa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "iskeletSistemi";
            this.Text = "iskeletSistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKafa;
        private System.Windows.Forms.Button btnKol;
        private System.Windows.Forms.Button btnGovde;
        private System.Windows.Forms.Button btnBacak;
    }
}