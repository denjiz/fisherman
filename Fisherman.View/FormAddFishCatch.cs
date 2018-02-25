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
    public partial class FormAddFishCatch : Form, IAddFishCatchView
    {
        private readonly PresenterAddFishCatch _presenter;

        public FormAddFishCatch(PresenterFishingRecord inParentPresenter)
        {
            InitializeComponent();
            _presenter = new PresenterAddFishCatch(this, inParentPresenter as PresenterAddFishingRecord);
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
        }

        public string Mass
        {
            get { return tbxMass.Text; }
        }

        public void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddFishCatchRequest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.CloseRequest();
        }

        public void End()
        {
            this.Close();
        }


        public string SoldMass
        {
            get { return tbxSoldMass.Text; }
            set { tbxSoldMass.Text = value; }
        }

        public string SoldPrice
        {
            get { return tbxSoldPrice.Text; }
            set { tbxSoldPrice.Text = value; }
        }
    }
}
