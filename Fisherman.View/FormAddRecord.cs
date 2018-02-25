using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.BaseLibrary;

namespace Fisherman.View
{
    public partial class FormAddFishingRecord : Form
    {
        private IController _controller;

        public FormAddFishingRecord(IController controller, string[] locations, string[] winds, string[] moonPhases, string[] tides)
        {
            InitializeComponent();

            _controller = controller;

            comboBoxLocations.Items.AddRange(new string[]{"bla", "bli"});
            comboBoxWinds.Items.AddRange(winds);
            comboBoxMoonPhases.Items.AddRange(moonPhases);
            comboBoxTides.Items.AddRange(tides);
        }
    }
}
