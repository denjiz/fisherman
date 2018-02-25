using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.Presentation;
using Fisherman.BaseLibrary;

namespace Fisherman.View
{
    public partial class MainForm : Form, IMainView
    {
        private readonly MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
        }

        private void addRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _presenter.AddFishingRecordRequest();
        }

        public void ChangeToAddFishingRecordView()
        {
            AddFishingRecordForm form = new AddFishingRecordForm();
            form.ShowDialog();
        }
    }
}
