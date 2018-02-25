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
    public partial class FormFishSale : Form, IViewFishSale
    {
        private readonly PresenterFishSaleAdd _presenter;

        public FormFishSale(FormFishingRecord inForm)
        {
            InitializeComponent();
            _presenter = new PresenterFishSaleAdd(this);
            _presenter.Attach(inForm);
        }

        public string[] FishNames
        {
            set 
            {
                cbxFishNames.Items.AddRange(value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddFishSaleRequest();
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
            CommonFormStuff.ShowErrorMessage(text);
        }

        public string FishName
        {
            get { return cbxFishNames.Text; }
            set { cbxFishNames.Text = value; }
        }


        public void End()
        {
            Close();
        }


        public string Price
        {
            get { return tbxPrice.Text; }
            set { tbxPrice.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.CloseRequest();
        }
    }
}
