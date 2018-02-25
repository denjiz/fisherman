using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.DomainModel;
using Fisherman.View;
using Fisherman.BaseLibrary;

namespace Fisherman.Controllers
{
    public class Controller : IController
    {
        private FishingRecordRepository _recordRepository = FishingRecordRepository.GetInstance();

        public void AddFishingRecordRequest(Form caller)
        {
            string[] locations = { };
            string[] winds = System.Enum.GetNames(typeof(Winds));
            string[] moonPhases = System.Enum.GetNames(typeof(MoonPhases));
            string[] tides = System.Enum.GetNames(typeof(Tides));

            FormAddFishingRecord form = new FormAddFishingRecord(this, locations, winds, moonPhases, tides);
            form.ShowDialog();
        }
    }
}
