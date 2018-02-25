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
    public partial class FormAddLocation : Form, IAddLocationView
    {
        private readonly PresenterAddLocation _presenter;

        public FormAddLocation(FormLocations inForm)
        {
            InitializeComponent();
            _presenter = new PresenterAddLocation(this);
            _presenter.Attach(inForm);
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddLocationRequest(tbxName.Text, tbxLatitude.Text, tbxLongitude.Text, tbxDepth.Text, rctbxComment.Text);
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
    }
}
