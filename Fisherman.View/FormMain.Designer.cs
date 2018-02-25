namespace Fisherman.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxFishingRecords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxYears = new System.Windows.Forms.ComboBox();
            this.cbxMonths = new System.Windows.Forms.ComboBox();
            this.cbxLocations = new System.Windows.Forms.ComboBox();
            this.cbxWinds = new System.Windows.Forms.ComboBox();
            this.cbxMoonPhases = new System.Windows.Forms.ComboBox();
            this.cbxTides = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnDeselectSearchParams = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowAllRecords = new System.Windows.Forms.Button();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(161, 28);
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.addRecordToolStripMenuItem.Text = "add record...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.locationsToolStripMenuItem.Text = "Locations...";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // lbxFishingRecords
            // 
            this.lbxFishingRecords.FormattingEnabled = true;
            this.lbxFishingRecords.ItemHeight = 16;
            this.lbxFishingRecords.Location = new System.Drawing.Point(18, 33);
            this.lbxFishingRecords.Name = "lbxFishingRecords";
            this.lbxFishingRecords.Size = new System.Drawing.Size(244, 228);
            this.lbxFishingRecords.TabIndex = 4;
            this.lbxFishingRecords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxFishingRecords_KeyDown);
            this.lbxFishingRecords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxFishingRecords_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wind:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moon phase:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tide:";
            // 
            // cbxYears
            // 
            this.cbxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYears.FormattingEnabled = true;
            this.cbxYears.Location = new System.Drawing.Point(102, 33);
            this.cbxYears.Name = "cbxYears";
            this.cbxYears.Size = new System.Drawing.Size(164, 24);
            this.cbxYears.Sorted = true;
            this.cbxYears.TabIndex = 12;
            // 
            // cbxMonths
            // 
            this.cbxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonths.FormattingEnabled = true;
            this.cbxMonths.Location = new System.Drawing.Point(102, 63);
            this.cbxMonths.Name = "cbxMonths";
            this.cbxMonths.Size = new System.Drawing.Size(164, 24);
            this.cbxMonths.Sorted = true;
            this.cbxMonths.TabIndex = 14;
            // 
            // cbxLocations
            // 
            this.cbxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocations.FormattingEnabled = true;
            this.cbxLocations.Location = new System.Drawing.Point(102, 93);
            this.cbxLocations.Name = "cbxLocations";
            this.cbxLocations.Size = new System.Drawing.Size(164, 24);
            this.cbxLocations.Sorted = true;
            this.cbxLocations.TabIndex = 15;
            // 
            // cbxWinds
            // 
            this.cbxWinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWinds.FormattingEnabled = true;
            this.cbxWinds.Location = new System.Drawing.Point(102, 123);
            this.cbxWinds.Name = "cbxWinds";
            this.cbxWinds.Size = new System.Drawing.Size(164, 24);
            this.cbxWinds.TabIndex = 16;
            // 
            // cbxMoonPhases
            // 
            this.cbxMoonPhases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoonPhases.FormattingEnabled = true;
            this.cbxMoonPhases.Location = new System.Drawing.Point(102, 153);
            this.cbxMoonPhases.Name = "cbxMoonPhases";
            this.cbxMoonPhases.Size = new System.Drawing.Size(164, 24);
            this.cbxMoonPhases.TabIndex = 17;
            // 
            // cbxTides
            // 
            this.cbxTides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTides.FormattingEnabled = true;
            this.cbxTides.Location = new System.Drawing.Point(102, 183);
            this.cbxTides.Name = "cbxTides";
            this.cbxTides.Size = new System.Drawing.Size(164, 24);
            this.cbxTides.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 279);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 32);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(147, 279);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(119, 32);
            this.btnStatistics.TabIndex = 21;
            this.btnStatistics.Text = "Statistics...";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnDeselectSearchParams
            // 
            this.btnDeselectSearchParams.Location = new System.Drawing.Point(191, 213);
            this.btnDeselectSearchParams.Name = "btnDeselectSearchParams";
            this.btnDeselectSearchParams.Size = new System.Drawing.Size(75, 23);
            this.btnDeselectSearchParams.TabIndex = 22;
            this.btnDeselectSearchParams.Text = "Clear all";
            this.btnDeselectSearchParams.UseVisualStyleBackColor = true;
            this.btnDeselectSearchParams.Click += new System.EventHandler(this.btnDeselectSearchParams_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(18, 279);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(120, 32);
            this.btnAddRecord.TabIndex = 25;
            this.btnAddRecord.Text = "Add record...";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxYears);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnStatistics);
            this.groupBox1.Controls.Add(this.btnDeselectSearchParams);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxMonths);
            this.groupBox1.Controls.Add(this.cbxLocations);
            this.groupBox1.Controls.Add(this.cbxTides);
            this.groupBox1.Controls.Add(this.cbxWinds);
            this.groupBox1.Controls.Add(this.cbxMoonPhases);
            this.groupBox1.Location = new System.Drawing.Point(298, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 324);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search and statistics";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowAllRecords);
            this.groupBox2.Controls.Add(this.btnAddRecord);
            this.groupBox2.Controls.Add(this.lbxFishingRecords);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 324);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fishing records";
            // 
            // btnShowAllRecords
            // 
            this.btnShowAllRecords.Location = new System.Drawing.Point(142, 279);
            this.btnShowAllRecords.Name = "btnShowAllRecords";
            this.btnShowAllRecords.Size = new System.Drawing.Size(120, 32);
            this.btnShowAllRecords.TabIndex = 26;
            this.btnShowAllRecords.Text = "Show all records";
            this.btnShowAllRecords.UseVisualStyleBackColor = true;
            this.btnShowAllRecords.Click += new System.EventHandler(this.btnShowAllRecords_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 375);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisherman";
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxFishingRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxYears;
        private System.Windows.Forms.ComboBox cbxMonths;
        private System.Windows.Forms.ComboBox cbxLocations;
        private System.Windows.Forms.ComboBox cbxWinds;
        private System.Windows.Forms.ComboBox cbxMoonPhases;
        private System.Windows.Forms.ComboBox cbxTides;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnDeselectSearchParams;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowAllRecords;

    }
}

