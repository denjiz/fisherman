namespace Fisherman.Forms
{
    partial class FormFishingRecordEditor
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMoonPhases = new System.Windows.Forms.ComboBox();
            this.cbxTides = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxFishCatch = new System.Windows.Forms.ListBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxWinds = new System.Windows.Forms.ComboBox();
            this.btnAddCatch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // cbxLocations
            // 
            this.cbxLocations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLocations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocations.FormattingEnabled = true;
            this.cbxLocations.Location = new System.Drawing.Point(15, 116);
            this.cbxLocations.Name = "cbxLocations";
            this.cbxLocations.Size = new System.Drawing.Size(241, 24);
            this.cbxLocations.Sorted = true;
            this.cbxLocations.TabIndex = 1;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "  HH:mm                  dd.MM.yyyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(56, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 22);
            this.dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "  HH:mm                  dd.MM.yyyy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(56, 57);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 22);
            this.dtEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date and time";
            // 
            // cbxMoonPhases
            // 
            this.cbxMoonPhases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoonPhases.FormattingEnabled = true;
            this.cbxMoonPhases.Location = new System.Drawing.Point(15, 210);
            this.cbxMoonPhases.Name = "cbxMoonPhases";
            this.cbxMoonPhases.Size = new System.Drawing.Size(241, 24);
            this.cbxMoonPhases.TabIndex = 9;
            // 
            // cbxTides
            // 
            this.cbxTides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTides.FormattingEnabled = true;
            this.cbxTides.Location = new System.Drawing.Point(15, 257);
            this.cbxTides.Name = "cbxTides";
            this.cbxTides.Size = new System.Drawing.Size(241, 24);
            this.cbxTides.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moon phase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tides";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fish catch";
            // 
            // lbxFishCatch
            // 
            this.lbxFishCatch.FormattingEnabled = true;
            this.lbxFishCatch.ItemHeight = 16;
            this.lbxFishCatch.Location = new System.Drawing.Point(288, 37);
            this.lbxFishCatch.Name = "lbxFishCatch";
            this.lbxFishCatch.Size = new System.Drawing.Size(239, 180);
            this.lbxFishCatch.TabIndex = 15;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(128, 317);
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
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wind";
            // 
            // cbxWinds
            // 
            this.cbxWinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWinds.FormattingEnabled = true;
            this.cbxWinds.Location = new System.Drawing.Point(15, 163);
            this.cbxWinds.Name = "cbxWinds";
            this.cbxWinds.Size = new System.Drawing.Size(241, 24);
            this.cbxWinds.TabIndex = 8;
            // 
            // btnAddCatch
            // 
            this.btnAddCatch.Location = new System.Drawing.Point(354, 228);
            this.btnAddCatch.Name = "btnAddCatch";
            this.btnAddCatch.Size = new System.Drawing.Size(118, 23);
            this.btnAddCatch.TabIndex = 17;
            this.btnAddCatch.Text = "Add catch...";
            this.btnAddCatch.UseVisualStyleBackColor = true;
            this.btnAddCatch.Click += new System.EventHandler(this.btnAddCatch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddFishingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCatch);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lbxFishCatch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTides);
            this.Controls.Add(this.cbxMoonPhases);
            this.Controls.Add(this.cbxWinds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cbxLocations);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddFishingRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Fishing Record";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMoonPhases;
        private System.Windows.Forms.ComboBox cbxTides;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxFishCatch;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxWinds;
        private System.Windows.Forms.Button btnAddCatch;
        private System.Windows.Forms.Button btnCancel;
    }
}