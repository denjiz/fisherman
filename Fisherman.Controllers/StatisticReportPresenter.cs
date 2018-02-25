using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;

namespace Fisherman.Presenters
{
    public class StatisticReportPresenter
    {
        private readonly IStatisticReportView _view;

        public StatisticReportPresenter(IStatisticReportView inView)
        {
            _view = inView;
        }

        public void CloseRequest()
        {
            _view.End();
        }
    }
}
