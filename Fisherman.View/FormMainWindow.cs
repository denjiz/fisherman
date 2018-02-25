using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.Controllers;
using Fisherman.BaseLibrary;

namespace Fisherman.View
{
    public partial class FormMainWindow : Form, IMainView
    {
        private readonly MainPresenter _presenter = new MainPresenter(this);

        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void addRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _presenter.AddFishingRecordRequest();
        }
    }
}
