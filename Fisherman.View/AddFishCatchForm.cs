using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.BaseLibrary;
using Fisherman.Presentation;

namespace Fisherman.View
{
    public partial class AddFishCatchForm : Form, IAddFishCatchView
    {
        private readonly AddFishCatchPresenter _presenter;

        public AddFishCatchForm(AddFishingRecordPresenter inParentPresenter)
        {
            InitializeComponent();
            _presenter = new AddFishCatchPresenter(this, inParentPresenter);
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
    }
}
