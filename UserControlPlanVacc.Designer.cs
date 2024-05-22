namespace MilkDistributionApp
{
    partial class UserControlPlanVacc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(4, 5);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(22, 16);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "00";
            this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // UserControlPlanVacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblDays);
            this.Name = "UserControlPlanVacc";
            this.Size = new System.Drawing.Size(34, 25);
            this.Click += new System.EventHandler(this.UserControlPlanVacc_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
    }
}
