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
    public partial class FormFishingRecord : Form, IViewFishingRecord, IFishermanObserver
    {
        private readonly PresenterFishingRecord _presenter;

        public FormFishingRecord()
        {
            InitializeComponent();
            _presenter = new PresenterFishingRecordAdd(this);

            DateTime now = DateTime.Now;
            DateTime dateTime = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTimeStart = dateTime;
            DateTimeEnd = dateTime;
        }

        public FormFishingRecord(int index)
        {
            InitializeComponent();
            _presenter = new PresenterFishingRecordEdit(this, index);
        }

        public DateTime DateTimeStart
        {
            get { return dtStart.Value; }
            set { dtStart.Value = value; }
        }

        public DateTime DateTimeEnd
        {
            get { return dtEnd.Value; }
            set { dtEnd.Value = value; }
        }

        public new string Location
        {
            get { return cbxLocations.Text; }
            set { cbxLocations.Text = value; }
        }

        public string Wind
        {
            get { return cbxWinds.Text; }
            set { cbxWinds.Text = value; }
        }

        public string MoonPhase
        {
            get { return cbxMoonPhases.Text; }
            set { cbxMoonPhases.Text = value; }
        }

        public string Tide
        {
            get { return cbxTides.Text; }
            set { cbxTides.Text = value; }
        }

        public void AddFishCatch(string inFish, double inMass)
        {
            dtgrdFishCatch.Rows.Add(inFish, inMass.ToString("0.00"));
        }

        public void AddFishSale(string inFish, double inMass, double inPrice)
        {
            dtgrdFishSale.Rows.Add(inFish, inMass.ToString("0.00"), inPrice.ToString("0.00"));
        }

        public void DeleteFishCatch(string inFish)
        {
            int index = FindRowIndex(dtgrdFishCatch, 0, inFish);
            dtgrdFishCatch.Rows.RemoveAt(index);
        }

        public void DeleteFishSale(string inFish)
        {
            int index = FindRowIndex(dtgrdFishSale, 0, inFish);
            dtgrdFishSale.Rows.RemoveAt(index);
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

        public void ChangeToFishCatchAddView()
        {
            FormFishCatch form = new FormFishCatch(this);
            form.ShowDialog();
        }

        public void ChangeToFishSaleAddView()
        {
            FormFishSale form = new FormFishSale(this);
            form.ShowDialog();
        }

        public void SetFinishButtonText(string text)
        {
            btnAddRecord.Text = text;
        }

        public void ShowMessage(string text)
        {
            CommonFormStuff.ShowMessage(text);
        }

        public bool WarnUser(string text)
        {
            return CommonFormStuff.WarnUser(text);
        }

        public void ShowErrorMessage(string text)
        {
            CommonFormStuff.ShowErrorMessage(text);
        }

        public void End()
        {
            Close();
        }

        public void Update(object inObject)
        {
            _presenter.Update(inObject);
        }

        private void btnAddCatch_Click(object sender, EventArgs e)
        {
            _presenter.AddFishCatchRequest();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            _presenter.AddFishSaleRequest();
        }

        private void btnDeleteSelectedCatch_Click(object sender, EventArgs e)
        {
            int index = TryGetGridSelectedIndex(dtgrdFishCatch);
            if (index != -1)
            {
                string fish = dtgrdFishCatch.Rows[index].Cells[0].Value.ToString();
                _presenter.DeleteFishCatchRequest(fish);
            }
        }

        private void btnDeleteSelectedSale_Click(object sender, EventArgs e)
        {
            int index = TryGetGridSelectedIndex(dtgrdFishSale);
            if (index != -1)
            {
                string fish = dtgrdFishSale.Rows[index].Cells[0].Value.ToString();
                _presenter.DeleteFishSaleRequest(fish);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            _presenter.FinishRequest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.CancelRequest();
        }

        private int TryGetGridSelectedIndex(DataGridView inDataGrid)
        {
            int index;

            try
            {
                index = inDataGrid.CurrentCell.RowIndex;
            }
            catch (Exception)
            {
                CommonFormStuff.ShowErrorMessage("One row must be selected!");
                return -1;
            }

            return index;
        }

        private int FindRowIndex(DataGridView inDataGrid, int inColumnIndex, string inValue)
        {
            int index = -1;

            foreach (DataGridViewRow row in inDataGrid.Rows)
            {
                if (row.Cells[inColumnIndex].Value.ToString() == inValue)
                {
                    index = row.Index;
                }
            }

            return index;
        }
    }
}
