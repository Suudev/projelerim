namespace BDO_Bahar_FinalProjesi
{
    partial class icOrganlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(icOrganlar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKafa = new System.Windows.Forms.Button();
            this.btnGogus = new System.Windows.Forms.Button();
            this.btnUstKarin = new System.Windows.Forms.Button();
            this.btnAltKarin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(315, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 475);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnKafa
            // 
            this.btnKafa.Location = new System.Drawing.Point(610, 69);
            this.btnKafa.Name = "btnKafa";
            this.btnKafa.Size = new System.Drawing.Size(85, 35);
            this.btnKafa.TabIndex = 3;
            this.btnKafa.Text = "Kafa";
            this.btnKafa.UseVisualStyleBackColor = true;
            // 
            // btnGogus
            // 
            this.btnGogus.Location = new System.Drawing.Point(224, 236);
            this.btnGogus.Name = "btnGogus";
            this.btnGogus.Size = new System.Drawing.Size(85, 35);
            this.btnGogus.TabIndex = 4;
            this.btnGogus.Text = "Göğüs";
            this.btnGogus.UseVisualStyleBackColor = true;
            // 
            // btnUstKarin
            // 
            this.btnUstKarin.Location = new System.Drawing.Point(610, 310);
            this.btnUstKarin.Name = "btnUstKarin";
            this.btnUstKarin.Size = new System.Drawing.Size(85, 35);
            this.btnUstKarin.TabIndex = 5;
            this.btnUstKarin.Text = "Üst Karın";
            this.btnUstKarin.UseVisualStyleBackColor = true;
            // 
            // btnAltKarin
            // 
            this.btnAltKarin.Location = new System.Drawing.Point(224, 405);
            this.btnAltKarin.Name = "btnAltKarin";
            this.btnAltKarin.Size = new System.Drawing.Size(85, 35);
            this.btnAltKarin.TabIndex = 6;
            this.btnAltKarin.Text = "Alt Karın";
            this.btnAltKarin.UseVisualStyleBackColor = true;
            // 
            // icOrganlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 618);
            this.Controls.Add(this.btnAltKarin);
            this.Controls.Add(this.btnUstKarin);
            this.Controls.Add(this.btnGogus);
            this.Controls.Add(this.btnKafa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "icOrganlar";
            this.Text = "icOrganlar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKafa;
        private System.Windows.Forms.Button btnGogus;
        private System.Windows.Forms.Button btnUstKarin;
        private System.Windows.Forms.Button btnAltKarin;
    }
}