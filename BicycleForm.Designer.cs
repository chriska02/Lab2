namespace Lab2
{
    partial class BicycleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(90, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.Text = "Bicycle Rental";
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(30, 55);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(250, 45);
            this.lblRates.Text = "0h-7h and 21h-24h : 500 RWF/hour\r\n" +
                                 "7h-14h and 19h-21h : 1000 RWF/hour\r\n" +
                                 "14h-19h : 1500 RWF/hour";
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(30, 118);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(110, 15);
            this.lblStart.Text = "Start hour (0 - 23):";
            this.txtStart.Location = new System.Drawing.Point(160, 115);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(140, 23);
            this.txtStart.TabIndex = 0;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(30, 153);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(105, 15);
            this.lblEnd.Text = "End hour (1 - 24):";
            this.txtEnd.Location = new System.Drawing.Point(160, 150);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(140, 23);
            this.txtEnd.TabIndex = 1;
            this.btnCalculate.Location = new System.Drawing.Point(160, 185);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 30);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 233);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.Text = "Total:";
            this.txtTotal.Location = new System.Drawing.Point(160, 230);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(140, 23);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TabStop = false;
            this.btnBack.Location = new System.Drawing.Point(30, 275);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnLogout.Location = new System.Drawing.Point(200, 275);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BicycleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicycle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BicycleForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
    }
}
