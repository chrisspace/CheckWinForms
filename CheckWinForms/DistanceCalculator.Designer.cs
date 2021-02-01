namespace CheckWinForms
{
    partial class frmDistanceCalculator
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
            this.btnCalculateDistance = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDistanceCalc = new System.Windows.Forms.TextBox();
            this.lblDistanceCalculated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateDistance
            // 
            this.btnCalculateDistance.Location = new System.Drawing.Point(438, 243);
            this.btnCalculateDistance.Name = "btnCalculateDistance";
            this.btnCalculateDistance.Size = new System.Drawing.Size(137, 59);
            this.btnCalculateDistance.TabIndex = 0;
            this.btnCalculateDistance.Text = "Calculate Distance";
            this.btnCalculateDistance.UseVisualStyleBackColor = true;
            this.btnCalculateDistance.Click += new System.EventHandler(this.btnCalculateDistance_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(101, 66);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(97, 15);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "Speed (km/hour)";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(101, 147);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(87, 15);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Time (in hours)";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(339, 66);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(183, 23);
            this.txtSpeed.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(339, 147);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(183, 23);
            this.txtTime.TabIndex = 4;
            // 
            // txtDistanceCalc
            // 
            this.txtDistanceCalc.Location = new System.Drawing.Point(339, 376);
            this.txtDistanceCalc.Name = "txtDistanceCalc";
            this.txtDistanceCalc.Size = new System.Drawing.Size(183, 23);
            this.txtDistanceCalc.TabIndex = 5;
            // 
            // lblDistanceCalculated
            // 
            this.lblDistanceCalculated.Location = new System.Drawing.Point(54, 360);
            this.lblDistanceCalculated.Name = "lblDistanceCalculated";
            this.lblDistanceCalculated.Size = new System.Drawing.Size(200, 39);
            this.lblDistanceCalculated.TabIndex = 6;
            this.lblDistanceCalculated.Text = "Distance Calculated";
            this.lblDistanceCalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDistanceCalculated);
            this.Controls.Add(this.txtDistanceCalc);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnCalculateDistance);
            this.Name = "frmDistanceCalculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateDistance;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDistanceCalc;
        private System.Windows.Forms.Label lblDistanceCalculated;
    }
}