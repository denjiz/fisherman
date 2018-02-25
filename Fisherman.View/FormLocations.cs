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
    public partial class FormLocations : Form, IViewLocations
    {
        private readonly PresenterLocations _presenter;

        public FormLocations()
        {
            InitializeComponent();
            _presenter = new PresenterLocations(this);
        }

        public void AddLocation(string inName, double inLatitude, double inLongitude, double inDepth, string inComment)
        {
            ListViewItem rowItem = CreateRowItem(inName, inLatitude.ToString(), inLongitude.ToString(),
                inDepth.ToString(), inComment);

            lstvLocations.Items.Add(rowItem);
        }

        public void UpdateLocation(string inName, double inLatitude, double inLongitude, double inDepth, string inComment)
        {
            ListViewItem rowItem = CreateRowItem(inName, inLatitude.ToString(), inLongitude.ToString(), inDepth.ToString(), inComment);

            int index = lstvLocations.Items.IndexOfKey(inName);
            lstvLocations.Items[index] = rowItem;
        }

        public void DeleteLocation(int inLocationIndex)
        {
            lstvLocations.Items.RemoveAt(inLocationIndex);
        }

        public void DeleteLocations()
        {
            lstvLocations.Items.Clear();
        }

        public bool ContainsLocation(string inName)
        {
            if (lstvLocations.Items.ContainsKey(inName))
            {
                return true;
            }

            return false;
        }

        public void ChangeToLocationAddView()
        {
            FormLocation form = new FormLocation();
            form.ShowDialog();
        }

        public void ChangeToLocationEditView(int index)
        {
            FormLocation form = new FormLocation(index);
            form.ShowDialog();
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

        public void End()
        {
            Close();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            _presenter.AddLocationRequest();
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (lstvLocations.SelectedItems.Count != 1)
            {
                CommonFormStuff.ShowErrorMessage("One location must be selected!");
            }
            else
            {
                _presenter.EditLocationRequest(lstvLocations.SelectedIndices[0]);
            }        
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lstvLocations.SelectedItems.Count != 1)
            {
                CommonFormStuff.ShowErrorMessage("One location must be selected!");
            }
            else
            {
                _presenter.DeleteLocationRequest(lstvLocations.SelectedIndices[0]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _presenter.CloseRequest();
        }

        private ListViewItem CreateRowItem(string inName, string inLatitude, string inLongitude, string inDepth, string inComment)
        {
            string[] row = {inName, inLatitude, inLongitude, inDepth, inComment};
            ListViewItem rowItem = new ListViewItem(row);
            rowItem.Name = inName;

            return rowItem;
        }
    }
}
