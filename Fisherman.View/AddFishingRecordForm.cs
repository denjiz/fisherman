using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.Presentation;
using Fisherman.BaseLibrary;

namespace Fisherman.View
{
    public partial class AddFishingRecordForm : Form, IAddFishingRecordView
    {
        private readonly AddFishingRecordPresenter _presenter;

        public AddFishingRecordForm()
        {
            InitializeComponent();
            _presenter = new AddFishingRecordPresenter(this);

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
            AddFishCatchForm form = new AddFishCatchForm(_presenter);
            form.ShowDialog();
        }

        public void AddFishCatch(string fishName, double mass)
        {
            lbxFishCatch.Items.Add(fishName + " " + mass.ToString() + " kg");
        }
    }
}
