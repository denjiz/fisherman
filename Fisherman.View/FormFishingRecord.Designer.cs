namespace Fisherman.Forms
{
    partial class FormFishingRecord
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
            this.cbxLocations = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMoonPhases = new System.Windows.Forms.ComboBox();
            this.cbxTides = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxWinds = new System.Windows.Forms.ComboBox();
            this.btnAddCatch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgrdFishCatch = new System.Windows.Forms.DataGridView();
            this.ColumnFish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelectedCatch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgrdFishSale = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelectedSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFishCatch)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFishSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // cbxLocations
            // 
            this.cbxLocations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLocations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocations.FormattingEnabled = true;
            this.cbxLocations.Location = new System.Drawing.Point(96, 122);
            this.cbxLocations.Name = "cbxLocations";
            this.cbxLocations.Size = new System.Drawing.Size(195, 24);
            this.cbxLocations.Sorted = true;
            this.cbxLocations.TabIndex = 1;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "  HH:mm                  dd.MM.yyyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(52, 33);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 22);
            this.dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "  HH:mm                  dd.MM.yyyy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(52, 61);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 22);
            this.dtEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "End:";
            // 
            // cbxMoonPhases
            // 
            this.cbxMoonPhases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoonPhases.FormattingEnabled = true;
            this.cbxMoonPhases.Location = new System.Drawing.Point(99, 62);
            this.cbxMoonPhases.Name = "cbxMoonPhases";
            this.cbxMoonPhases.Size = new System.Drawing.Size(177, 24);
            this.cbxMoonPhases.TabIndex = 9;
            // 
            // cbxTides
            // 
            this.cbxTides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTides.FormattingEnabled = true;
            this.cbxTides.Location = new System.Drawing.Point(99, 92);
            this.cbxTides.Name = "cbxTides";
            this.cbxTides.Size = new System.Drawing.Size(177, 24);
            this.cbxTides.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moon phase:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tide:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(314, 336);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(142, 38);
            this.btnAddRecord.TabIndex = 16;
            this.btnAddRecord.Text = "Add record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wind:";
            // 
            // cbxWinds
            // 
            this.cbxWinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWinds.FormattingEnabled = true;
            this.cbxWinds.Location = new System.Drawing.Point(99, 32);
            this.cbxWinds.Name = "cbxWinds";
            this.cbxWinds.Size = new System.Drawing.Size(177, 24);
            this.cbxWinds.TabIndex = 8;
            // 
            // btnAddCatch
            // 
            this.btnAddCatch.Location = new System.Drawing.Point(34, 256);
            this.btnAddCatch.Name = "btnAddCatch";
            this.btnAddCatch.Size = new System.Drawing.Size(94, 23);
            this.btnAddCatch.TabIndex = 17;
            this.btnAddCatch.Text = "Add catch...";
            this.btnAddCatch.UseVisualStyleBackColor = true;
            this.btnAddCatch.Click += new System.EventHandler(this.btnAddCatch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 103);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTides);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxMoonPhases);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxWinds);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 128);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nature events";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgrdFishCatch);
            this.groupBox3.Controls.Add(this.btnDeleteSelectedCatch);
            this.groupBox3.Controls.Add(this.btnAddCatch);
            this.groupBox3.Location = new System.Drawing.Point(314, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 292);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fish catch";
            // 
            // dtgrdFishCatch
            // 
            this.dtgrdFishCatch.AllowUserToAddRows = false;
            this.dtgrdFishCatch.AllowUserToDeleteRows = false;
            this.dtgrdFishCatch.AllowUserToResizeColumns = false;
            this.dtgrdFishCatch.AllowUserToResizeRows = false;
            this.dtgrdFishCatch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgrdFishCatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdFishCatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFish,
            this.ColumnMass});
            this.dtgrdFishCatch.EnableHeadersVisualStyles = false;
            this.dtgrdFishCatch.Location = new System.Drawing.Point(6, 21);
            this.dtgrdFishCatch.MultiSelect = false;
            this.dtgrdFishCatch.Name = "dtgrdFishCatch";
            this.dtgrdFishCatch.ReadOnly = true;
            this.dtgrdFishCatch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgrdFishCatch.RowHeadersVisible = false;
            this.dtgrdFishCatch.RowTemplate.Height = 20;
            this.dtgrdFishCatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdFishCatch.Size = new System.Drawing.Size(287, 225);
            this.dtgrdFishCatch.TabIndex = 7;
            // 
            // ColumnFish
            // 
            this.ColumnFish.HeaderText = "Fish";
            this.ColumnFish.Name = "ColumnFish";
            this.ColumnFish.ReadOnly = true;
            this.ColumnFish.Width = 142;
            // 
            // ColumnMass
            // 
            this.ColumnMass.HeaderText = "Mass [kg]";
            this.ColumnMass.Name = "ColumnMass";
            this.ColumnMass.ReadOnly = true;
            this.ColumnMass.Width = 142;
            // 
            // btnDeleteSelectedCatch
            // 
            this.btnDeleteSelectedCatch.Location = new System.Drawing.Point(134, 256);
            this.btnDeleteSelectedCatch.Name = "btnDeleteSelectedCatch";
            this.btnDeleteSelectedCatch.Size = new System.Drawing.Size(133, 23);
            this.btnDeleteSelectedCatch.TabIndex = 18;
            this.btnDeleteSelectedCatch.Text = "Delete selected";
            this.btnDeleteSelectedCatch.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedCatch.Click += new System.EventHandler(this.btnDeleteSelectedCatch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgrdFishSale);
            this.groupBox4.Controls.Add(this.btnDeleteSelectedSale);
            this.groupBox4.Controls.Add(this.btnAddSale);
            this.groupBox4.Location = new System.Drawing.Point(619, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 292);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fish sale";
            // 
            // dtgrdFishSale
            // 
            this.dtgrdFishSale.AllowUserToAddRows = false;
            this.dtgrdFishSale.AllowUserToDeleteRows = false;
            this.dtgrdFishSale.AllowUserToResizeColumns = false;
            this.dtgrdFishSale.AllowUserToResizeRows = false;
            this.dtgrdFishSale.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgrdFishSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdFishSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColumnPrice});
            this.dtgrdFishSale.EnableHeadersVisualStyles = false;
            this.dtgrdFishSale.Location = new System.Drawing.Point(6, 21);
            this.dtgrdFishSale.MultiSelect = false;
            this.dtgrdFishSale.Name = "dtgrdFishSale";
            this.dtgrdFishSale.ReadOnly = true;
            this.dtgrdFishSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgrdFishSale.RowHeadersVisible = false;
            this.dtgrdFishSale.RowTemplate.Height = 20;
            this.dtgrdFishSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdFishSale.Size = new System.Drawing.Size(283, 225);
            this.dtgrdFishSale.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fish";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mass [kg]";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price [kn]";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // btnDeleteSelectedSale
            // 
            this.btnDeleteSelectedSale.Location = new System.Drawing.Point(133, 256);
            this.btnDeleteSelectedSale.Name = "btnDeleteSelectedSale";
            this.btnDeleteSelectedSale.Size = new System.Drawing.Size(133, 23);
            this.btnDeleteSelectedSale.TabIndex = 19;
            this.btnDeleteSelectedSale.Text = "Delete selected";
            this.btnDeleteSelectedSale.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedSale.Click += new System.EventHandler(this.btnDeleteSelectedSale_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(33, 256);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(94, 23);
            this.btnAddSale.TabIndex = 17;
            this.btnAddSale.Text = "Add sale...";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // FormFishingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 386);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxLocations);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormFishingRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fishing Record";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFishCatch)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFishSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLocations;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMoonPhases;
        private System.Windows.Forms.ComboBox cbxTides;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxWinds;
        private System.Windows.Forms.Button btnAddCatch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteSelectedCatch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteSelectedSale;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.DataGridView dtgrdFishCatch;
        private System.Windows.Forms.DataGridView dtgrdFishSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMass;
    }
}