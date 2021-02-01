namespace CheckWinForms
{
    partial class frmLatinTranslator
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
            this.btnSinisterTransl = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnDexter = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinisterTransl
            // 
            this.btnSinisterTransl.Location = new System.Drawing.Point(44, 361);
            this.btnSinisterTransl.Name = "btnSinisterTransl";
            this.btnSinisterTransl.Size = new System.Drawing.Size(75, 23);
            this.btnSinisterTransl.TabIndex = 0;
            this.btnSinisterTransl.Text = "Sinister";
            this.btnSinisterTransl.UseVisualStyleBackColor = true;
            this.btnSinisterTransl.Click += new System.EventHandler(this.btnSinisterTransl_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(341, 361);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnDexter
            // 
            this.btnDexter.Location = new System.Drawing.Point(620, 361);
            this.btnDexter.Name = "btnDexter";
            this.btnDexter.Size = new System.Drawing.Size(75, 23);
            this.btnDexter.TabIndex = 2;
            this.btnDexter.Text = "Dexter";
            this.btnDexter.UseVisualStyleBackColor = true;
            this.btnDexter.Click += new System.EventHandler(this.btnDexter_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(341, 215);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 15);
            this.lblOutput.TabIndex = 3;
            // 
            // frmLatinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDexter);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSinisterTransl);
            this.Name = "frmLatinTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrLatinTranslator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinisterTransl;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnDexter;
        private System.Windows.Forms.Label lblOutput;
    }
}