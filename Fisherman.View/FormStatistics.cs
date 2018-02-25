using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.BaseLibrary;
using Fisherman.Presenters;

namespace Fisherman.Forms
{
    public partial class FormStatistics : Form, IViewStatistics
    {
        private readonly PresenterStatistics _presenter;

        public FormStatistics(PresenterMain inParentPresenter)
        {
            InitializeComponent();

            _presenter = new PresenterStatistics(this, inParentPresenter);
        }

        public void ShowNumberOfRecordsFound(int recordsFound, int recordsTotal)
        {
            lblRecordsFound.Text += recordsFound + "/" + recordsTotal;
        }

        public string[] AvailableReports
        {
            set
            {
                clbxAvailableReports.Items.Clear();
                clbxAvailableReports.Items.AddRange(value);
            }
        }

        public void ChangeToStatisticReportView(string report)
        {
            FormStatisticReport form = new FormStatisticReport(report);
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

        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (string item in clbxAvailableReports.CheckedItems)
            {
                checkedItems.Add(item);
            }

            _presenter.ShowStatisticsRequest(checkedItems.ToArray());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _presenter.CloseRequest();
        }
    }
}
