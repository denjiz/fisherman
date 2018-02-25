using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.Services;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class AddFishingRecordPresenter
    {
        private readonly IAddFishingRecordView _view;
        private readonly PresenterMain _parent;
        public FishCatch fishCatch { get; set; }
        private string _windEmptyError = "Wind must be selected!";
        private string _moonPhaseEmptyError = "Moon phase must be selected!";
        private string _tideEmptyError = "Tide must be selected!";

        public AddFishingRecordPresenter(IAddFishingRecordView inView, PresenterMain inParent)
        {
            _view = inView;
            _parent = inParent;
            fishCatch = new FishCatch();
            
            // fill view with data
            _view.Locations = LocationRepository.GetInstance().GetLocationNames();
            _view.Winds = EnumProcessor.GetDTOwinds();
            _view.MoonPhases = EnumProcessor.GetDTOmoonPhases();
            _view.Tides = EnumProcessor.GetDTOtides();
        }

        public void AddFishCatchRequest()
        {
            _view.ChangeToAddFishCatchView();
        }

        internal void AddFishCatch(string fishName, double mass, double saleMass, double salePrice)
        {
            try
            {
                fishCatch.AddCatch(fishName, mass);
            }
            catch (FishermanBaseException e)
            {
                _view.ShowErrorMessage(e.Info);
                return;
            }

            _view.AddFishCatch(fishName, mass);

            if (saleMass != -1)
            {
                try
                {
                    fishCatch.AddSale(fishName, saleMass, salePrice);
                }
                catch (FishermanBaseException e)
                {
                    _view.ShowErrorMessage(e.Info);
                    return;
                }
            }
        }

        public void CancelRequest()
        {
            _view.End();
        }

        public void AddFishingRecordRequest()
        {
            // ensure nature contex is not empty
            if (_view.Wind == "")
            {
                _view.ShowErrorMessage(_windEmptyError);
                return;
            }
            if (_view.MoonPhase == "")
            {
                _view.ShowErrorMessage(_moonPhaseEmptyError);
                return;
            }
            if (_view.Tide == "")
            {
                _view.ShowErrorMessage(_tideEmptyError);
                return;
            }
            
            Winds wind = CommonFunctionalities.GetWindEnum(_view.Wind);
            MoonPhases moonPhase = CommonFunctionalities.GetMoonPhaseEnum(_view.MoonPhase);
            Tides tide = CommonFunctionalities.GetTideEnum(_view.Tide);

            try
            {
                FishingRecord record = FishingRecordFactory.CreateFishingRecord(_view.StartDateTime, _view.EndDateTime,
                _view.Location, wind, moonPhase, tide, fishCatch);

                FishingRecordRepository.GetInstance().AddRecord(record);
            }
            catch (FishermanBaseException e)
            {
                _view.ShowErrorMessage(e.Info);
                return;
            }

            _parent.AddRecordName(DateTime.Now);

            _view.End();
        }
    }
}
