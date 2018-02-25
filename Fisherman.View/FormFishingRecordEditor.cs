using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.Presenters;
using Fisherman.BaseLibrary;

namespace Fisherman.Forms
{
    public partial class FormFishingRecordEditor : Form, IAddFishingRecordView
    {
        private readonly PresenterFishingRecord _presenter;
        private int index;

        public FormFishingRecordEditor(FormMain inForm)
        {
            InitializeComponent();
            _presenter = new PresenterAddFishingRecord(this);
            _presenter.Attach(inForm);

            DateTime now = DateTime.Now;
            DateTime dateTime = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            StartDateTime = dateTime;
            EndDateTime = dateTime;
        }

        public DateTime StartDateTime
        {
            get { return dtStart.Value; }
            set { dtStart.Value = value; }
        }

        public DateTime EndDateTime
        {
            get { return dtEnd.Value; }
            set { dtEnd.Value = value; }
        }

        public string[] Locations
        {
            set
            {
                cbxLocations.Items.Clear();
                cbxLocations.Items.AddRange(value);
            }
        }

        public string[] Winds
        {
            set
            {
                cbxWinds.Items.Clear();
                cbxWinds.Items.AddRange(value);
            }
        }

        public string[] MoonPhases
        {
            set 
            {
                cbxMoonPhases.Items.Clear();
                cbxMoonPhases.Items.AddRange(value);
            }
        }

        public string[] Tides
        {
            set
            {
                cbxTides.Items.Clear();
                cbxTides.Items.AddRange(value);
            }
        }

        public string[] FishCatch
        {
            get;
            set;
        }

        private void btnAddCatch_Click(object sender, EventArgs e)
        {
            _presenter.AddFishCatchRequest();
        }

        public void ChangeToAddFishCatchView()
        {
            FormAddFishCatch form = new FormAddFishCatch(_presenter);
            form.ShowDialog();
        }

        public void AddFishCatch(string fishName, double mass)
        {
            lbxFishCatch.Items.Add(fishName + " " + mass.ToString() + " kg");
        }

        public void End()
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.CancelRequest();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            _presenter.FinishRequest();
        }

        public void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public new string Location
        {
            get { return cbxLocations.Text; }
        }

        public string Wind
        {
            get { return cbxWinds.Text; }
        }

        public string MoonPhase
        {
            get { return cbxMoonPhases.Text; }
        }

        public string Tide
        {
            get { return cbxTides.Text; }
        }
    }
}
