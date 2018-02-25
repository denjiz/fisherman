using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;

namespace Fisherman.Presenters
{
    public class PresenterStatisticReport
    {
        private readonly IViewStatisticReport _view;

        public PresenterStatisticReport(IViewStatisticReport inView)
        {
            _view = inView;
        }

        public void PrintRequest()
        {
            _view.ShowPrintDialog();
        }

        public void CloseRequest()
        {
            _view.End();
        }
    }
}
