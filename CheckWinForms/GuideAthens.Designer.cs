namespace CheckWinForms
{
    partial class frmGuideAthens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuideAthens));
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHideInfo = new System.Windows.Forms.Button();
            this.pictureBoxAthens = new System.Windows.Forms.PictureBox();
            this.lblAcro = new System.Windows.Forms.Label();
            this.lblMoon = new System.Windows.Forms.Label();
            this.lblTheatre = new System.Windows.Forms.Label();
            this.lblThisio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAthens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(48, 388);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfo.TabIndex = 0;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(635, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHideInfo
            // 
            this.btnHideInfo.Location = new System.Drawing.Point(334, 388);
            this.btnHideInfo.Name = "btnHideInfo";
            this.btnHideInfo.Size = new System.Drawing.Size(75, 23);
            this.btnHideInfo.TabIndex = 3;
            this.btnHideInfo.Text = "Hide Info";
            this.btnHideInfo.UseVisualStyleBackColor = true;
            this.btnHideInfo.Click += new System.EventHandler(this.btnHideInfo_Click);
            // 
            // pictureBoxAthens
            // 
            this.pictureBoxAthens.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAthens.Image")));
            this.pictureBoxAthens.Location = new System.Drawing.Point(75, 23);
            this.pictureBoxAthens.Name = "pictureBoxAthens";
            this.pictureBoxAthens.Size = new System.Drawing.Size(590, 310);
            this.pictureBoxAthens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAthens.TabIndex = 5;
            this.pictureBoxAthens.TabStop = false;
            this.pictureBoxAthens.Click += new System.EventHandler(this.pictureBoxAthens_Click);
            // 
            // lblAcro
            // 
            this.lblAcro.AutoSize = true;
            this.lblAcro.Location = new System.Drawing.Point(556, 120);
            this.lblAcro.Name = "lblAcro";
            this.lblAcro.Size = new System.Drawing.Size(57, 15);
            this.lblAcro.TabIndex = 6;
            this.lblAcro.Text = "Akropolis";
            this.lblAcro.Visible = false;
            // 
            // lblMoon
            // 
            this.lblMoon.AutoSize = true;
            this.lblMoon.Location = new System.Drawing.Point(229, 75);
            this.lblMoon.Name = "lblMoon";
            this.lblMoon.Size = new System.Drawing.Size(39, 15);
            this.lblMoon.TabIndex = 7;
            this.lblMoon.Text = "Moon";
            this.lblMoon.Visible = false;
            // 
            // lblTheatre
            // 
            this.lblTheatre.AutoEllipsis = true;
            this.lblTheatre.AutoSize = true;
            this.lblTheatre.Location = new System.Drawing.Point(166, 270);
            this.lblTheatre.Name = "lblTheatre";
            this.lblTheatre.Size = new System.Drawing.Size(46, 15);
            this.lblTheatre.TabIndex = 8;
            this.lblTheatre.Text = "Theatre";
            this.lblTheatre.Visible = false;
            // 
            // lblThisio
            // 
            this.lblThisio.AutoSize = true;
            this.lblThisio.Location = new System.Drawing.Point(575, 281);
            this.lblThisio.Name = "lblThisio";
            this.lblThisio.Size = new System.Drawing.Size(38, 15);
            this.lblThisio.TabIndex = 9;
            this.lblThisio.Text = "Thisio";
            this.lblThisio.Visible = false;
            // 
            // frmGuideAthens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThisio);
            this.Controls.Add(this.lblTheatre);
            this.Controls.Add(this.lblMoon);
            this.Controls.Add(this.lblAcro);
            this.Controls.Add(this.pictureBoxAthens);
            this.Controls.Add(this.btnHideInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowInfo);
            this.Name = "frmGuideAthens";
            this.Text = "Guide Athens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAthens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHideInfo;
        private System.Windows.Forms.PictureBox pictureBoxAthens;
        private System.Windows.Forms.Label lblAcro;
        private System.Windows.Forms.Label lblMoon;
        private System.Windows.Forms.Label lblTheatre;
        private System.Windows.Forms.Label lblThisio;
    }
}