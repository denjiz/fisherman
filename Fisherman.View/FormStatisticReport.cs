using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using Fisherman.BaseLibrary;
using Fisherman.Presenters;

namespace Fisherman.Forms
{
    public partial class FormStatisticReport : Form, IViewStatisticReport
    {
        private readonly PresenterStatisticReport _presenter;

        // stuff for printing
        private PrintDocument printDocument;
        private string documentContent;

        public FormStatisticReport(string report)
        {
            InitializeComponent();
            _presenter = new PresenterStatisticReport(this);

            // set content
            rtbxReport.Text = report;

            // stuff for printing
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(document_PrintPage);
            documentContent = report;
        }

        public void ShowPrintDialog()
        {
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            _presenter.CloseRequest();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _presenter.PrintRequest();
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage;
            int linesPerPage;

            string stringToPrint = rtbxReport.Text;

            PointF upperLeftCorner = new PointF(e.MarginBounds.X, e.MarginBounds.Y);
            Font font = new Font("Courier new", 12.0f);

            // Sets the value of charactersOnPage to the number of characters  
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, font,
                e.MarginBounds.Size, StringFormat.GenericDefault,
                out charactersOnPage, out linesPerPage);
            /*
            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericDefault);
            */
            e.Graphics.DrawString(stringToPrint, font, Brushes.Black, upperLeftCorner);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed. 
            if (!e.HasMorePages)
            {
                stringToPrint = documentContent;
            }
        }
    }
}
