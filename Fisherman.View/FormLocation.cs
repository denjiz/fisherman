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
    public partial class FormLocation : Form, IViewLocation
    {
        private readonly PresenterLocation _presenter;

        public FormLocation()
        {
            InitializeComponent();
            _presenter = new PresenterLocationAdd(this);
        }

        public FormLocation(int index)
        {
            InitializeComponent();
            _presenter = new PresenterLocationEdit(this, index);
        }

        private void brnFinish_Click(object sender, EventArgs e)
        {
            _presenter.FinishRequest(tbxName.Text, tbxLatitude.Text, tbxLongitude.Text, tbxDepth.Text, rtbxComment.Text);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void End()
        {
            Close();
        }

        public void DisableLatitudeAndLongitudeChange()
        {
            tbxLatitude.Enabled = false;
            tbxLongitude.Enabled = false;
        }

        public void SetFinishButtonText(string text)
        {
            btnFinish.Text = text;
        }

        public string LocationName
        {
            get { return tbxName.Text; }
            set { tbxName.Text = value; }
        }

        public string Latitude
        {
            get { return tbxLatitude.Text; }
            set { tbxLatitude.Text = value; }
        }

        public string Longitude
        {
            get { return tbxLongitude.Text; }
            set { tbxLongitude.Text = value; }
        }

        public string Depth
        {
            get { return tbxDepth.Text; }
            set { tbxDepth.Text = value; }
        }

        public string Comment
        {
            get { return rtbxComment.Text; }
            set { rtbxComment.Text = value; }
        }
    }
}
