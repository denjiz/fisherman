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
    public partial class FormMain : Form, IViewMain
    {
        private readonly PresenterMain _presenter;

        public FormMain()
        {
            InitializeComponent();
            _presenter = new PresenterMain(this);
        }

        public void AddRecord(DateTime dateTime)
        {
            lbxFishingRecords.Items.Insert(0, CreateRecordFromDateTime(dateTime));
        }

        public void DeleteRecords()
        {
            lbxFishingRecords.Items.Clear();
        }

        public int[] Years
        {
            set
            {
                cbxYears.Items.Clear();
                foreach (var year in value)
                {
                    cbxYears.Items.Add(year);
                }
            }
        }

        public int[] Months
        {
            set
            {
                cbxMonths.Items.Clear();
                foreach (var month in value)
                {
                    cbxMonths.Items.Add(month);
                }
            }
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

        public string YearSearch
        {
            get { return cbxYears.Text; }
        }

        public string MonthSearch
        {
            get { return cbxMonths.Text; }
        }

        public string LocationSearch
        {
            get { return cbxLocations.Text; }
        }

        public string WindSearch
        {
            get { return cbxWinds.Text; }
        }

        public string MoonPhaseSearch
        {
            get { return cbxMoonPhases.Text; }
        }

        public string TideSearch
        {
            get { return cbxTides.Text; }
        }

        public void DeselectSearchParams()
        {
            cbxYears.SelectedIndex = -1;
            cbxMonths.SelectedIndex = -1;
            cbxLocations.SelectedIndex = -1;
            cbxWinds.SelectedIndex = -1;
            cbxMoonPhases.SelectedIndex = -1;
            cbxTides.SelectedIndex = -1;
        }

        public void ChangeToFishingRecordAddView()
        {
            FormFishingRecord form = new FormFishingRecord();
            form.ShowDialog();
        }

        public void ChangeToFishingRecordEditView(int index)
        {
            FormFishingRecord form = new FormFishingRecord(index);
            form.ShowDialog();
        }

        public void ChangeToLocationsView()
        {
            FormLocations form = new FormLocations();
            form.ShowDialog();
        }

        public void ChangeToStatisticsView()
        {
            FormStatistics form = new FormStatistics(_presenter);
            form.ShowDialog();
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

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            _presenter.AddFishingRecordRequest();
        }

        private void btnShowAllRecords_Click(object sender, EventArgs e)
        {
            _presenter.ShowAllRecordsRequest();
        }

        private void lbxFishingRecords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbxFishingRecords.SelectedIndex;

            if (index != -1)
            {
                index = lbxFishingRecords.Items.Count - index - 1;
                _presenter.EditFishingRecordRequest(index);
            }
        }

        private void lbxFishingRecords_KeyDown(object sender, KeyEventArgs e)
        {
            int index = lbxFishingRecords.SelectedIndex;

            if (index != -1)
            {
                index = lbxFishingRecords.Items.Count - index - 1;
                _presenter.DeleteRecordRequest(index);
            }
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presenter.ShowLocationsRequest();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _presenter.SearchRequest();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            _presenter.CalculateStatisticsRequest();
        }

        private void btnDeselectSearchParams_Click(object sender, EventArgs e)
        {
            _presenter.DeselectSearchParamsRequest();
        }

        private string CreateRecordFromDateTime(DateTime dateTime)
        {
            return dateTime.ToString("yyyy.MM.dd  HH:mm:ss");
        }
    }
}
