namespace CheckWinForms
{
    partial class frmClickablePhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClickablePhoto));
            this.pictureBoxAth = new System.Windows.Forms.PictureBox();
            this.pictureBoxNaf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaf)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAth
            // 
            this.pictureBoxAth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAth.Image")));
            this.pictureBoxAth.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxAth.Name = "pictureBoxAth";
            this.pictureBoxAth.Size = new System.Drawing.Size(333, 390);
            this.pictureBoxAth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAth.TabIndex = 0;
            this.pictureBoxAth.TabStop = false;
            this.pictureBoxAth.Click += new System.EventHandler(this.pictureBoxAth_Click);
            // 
            // pictureBoxNaf
            // 
            this.pictureBoxNaf.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNaf.Image")));
            this.pictureBoxNaf.Location = new System.Drawing.Point(412, 35);
            this.pictureBoxNaf.Name = "pictureBoxNaf";
            this.pictureBoxNaf.Size = new System.Drawing.Size(312, 390);
            this.pictureBoxNaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNaf.TabIndex = 1;
            this.pictureBoxNaf.TabStop = false;
            this.pictureBoxNaf.Click += new System.EventHandler(this.pictureBoxNaf_Click);
            // 
            // frmClickablePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxNaf);
            this.Controls.Add(this.pictureBoxAth);
            this.Name = "frmClickablePhoto";
            this.Text = "Clickable Photo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAth;
        private System.Windows.Forms.PictureBox pictureBoxNaf;
    }
}