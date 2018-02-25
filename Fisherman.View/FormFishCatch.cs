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
    public partial class FormFishCatch : Form, IViewAddFishCatch
    {
        private readonly PresenterFishCatchAdd _presenter;

        public FormFishCatch(FormFishingRecord inForm)
        {
            InitializeComponent();
            _presenter = new PresenterFishCatchAdd(this);
            _presenter.Attach(inForm);
        }

        public string[] FishNames
        {
            set
            {
                cbxFishNames.Items.AddRange(value);
            }
        }

        public string FishName
        {
            get { return cbxFishNames.Text; }
            set { cbxFishNames.Text = value; }
        }

        public string Mass
        {
            get { return tbxMass.Text; }
            set { tbxMass.Text = value; }
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
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void End()
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddFishCatchRequest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.CloseRequest();
        }
    }
}
