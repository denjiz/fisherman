using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;
using Fisherman.Presenters;

namespace Fisherman.Forms
{
    public partial class FormLocationEditor : Form, ILocationEditorView
    {
        private readonly PresenterLocation _presenter;

        public FormLocationEditor(FormLocations inForm)
        {
            InitializeComponent();
            _presenter = new PresenterAddLocation(this);
            _presenter.Attach(inForm);
        }

        public FormLocationEditor(int index, FormLocations inForm)
        {
            InitializeComponent();
            _presenter = new PresenterEditLocation(this, index);
            _presenter.Attach(inForm);
        }

        private void brnFinish_Click(object sender, EventArgs e)
        {
            _presenter.FinishRequest(tbxName.Text, tbxLatitude.Text, tbxLongitude.Text, tbxDepth.Text, rctbxComment.Text);
        }

        public void ShowErrorMessage(string text)
        {
            CommonFunctionalities.ShowErrorMessage(text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void End()
        {
            Close();
        }

        public void ShowLocation(Location location)
        {
            tbxName.Text = location.Name;
            tbxLatitude.Text = location.Latitude.ToString();
            tbxLongitude.Text = location.Longitude.ToString();
            tbxDepth.Text = location.Depth.ToString();
            rctbxComment.Text = location.Comment;
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
    }
}
