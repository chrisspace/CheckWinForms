namespace CheckWinForms
{
    partial class frmTemperatureConverter
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
            this.btnConvToFahr = new System.Windows.Forms.Button();
            this.lblEntrTemp = new System.Windows.Forms.Label();
            this.btnConvToCelc = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvToFahr
            // 
            this.btnConvToFahr.Location = new System.Drawing.Point(128, 200);
            this.btnConvToFahr.Name = "btnConvToFahr";
            this.btnConvToFahr.Size = new System.Drawing.Size(155, 82);
            this.btnConvToFahr.TabIndex = 0;
            this.btnConvToFahr.Text = "Convert to Fahrenheit";
            this.btnConvToFahr.UseVisualStyleBackColor = true;
            this.btnConvToFahr.Click += new System.EventHandler(this.btnConvToFahr_Click);
            // 
            // lblEntrTemp
            // 
            this.lblEntrTemp.AutoSize = true;
            this.lblEntrTemp.Location = new System.Drawing.Point(128, 57);
            this.lblEntrTemp.Name = "lblEntrTemp";
            this.lblEntrTemp.Size = new System.Drawing.Size(103, 15);
            this.lblEntrTemp.TabIndex = 1;
            this.lblEntrTemp.Text = "Enter Temperature";
            // 
            // btnConvToCelc
            // 
            this.btnConvToCelc.Location = new System.Drawing.Point(495, 200);
            this.btnConvToCelc.Name = "btnConvToCelc";
            this.btnConvToCelc.Size = new System.Drawing.Size(158, 82);
            this.btnConvToCelc.TabIndex = 2;
            this.btnConvToCelc.Text = "Convert To Celcius";
            this.btnConvToCelc.UseVisualStyleBackColor = true;
            this.btnConvToCelc.Click += new System.EventHandler(this.btnConvToCelc_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(506, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 23);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(153, 374);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(363, 23);
            this.txtOutput.TabIndex = 4;
            // 
            // frmTemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnConvToCelc);
            this.Controls.Add(this.lblEntrTemp);
            this.Controls.Add(this.btnConvToFahr);
            this.Name = "frmTemperatureConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvToFahr;
        private System.Windows.Forms.Label lblEntrTemp;
        private System.Windows.Forms.Button btnConvToCelc;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}