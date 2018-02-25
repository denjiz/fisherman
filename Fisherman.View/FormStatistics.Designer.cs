namespace Fisherman.Forms
{
    partial class FormStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsFound = new System.Windows.Forms.Label();
            this.clbxAvailableReports = new System.Windows.Forms.CheckedListBox();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Generate report for:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(62, 220);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsFound
            // 
            this.lblRecordsFound.AutoSize = true;
            this.lblRecordsFound.Location = new System.Drawing.Point(10, 9);
            this.lblRecordsFound.Name = "lblRecordsFound";
            this.lblRecordsFound.Size = new System.Drawing.Size(109, 17);
            this.lblRecordsFound.TabIndex = 15;
            this.lblRecordsFound.Text = "Records found: ";
            // 
            // clbxAvailableReports
            // 
            this.clbxAvailableReports.CheckOnClick = true;
            this.clbxAvailableReports.FormattingEnabled = true;
            this.clbxAvailableReports.Location = new System.Drawing.Point(13, 46);
            this.clbxAvailableReports.Name = "clbxAvailableReports";
            this.clbxAvailableReports.Size = new System.Drawing.Size(187, 123);
            this.clbxAvailableReports.TabIndex = 16;
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(33, 175);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(147, 39);
            this.btnShowStatistics.TabIndex = 17;
            this.btnShowStatistics.Text = "Show report";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 270);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.clbxAvailableReports);
            this.Controls.Add(this.lblRecordsFound);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsFound;
        private System.Windows.Forms.CheckedListBox clbxAvailableReports;
        private System.Windows.Forms.Button btnShowStatistics;

    }
}