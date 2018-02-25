using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public abstract class PresenterFishingRecord : Subject
    {
        protected readonly IViewFishingRecord _view;
        protected FishCatch _fishCatch;

        protected const string _fishingRecordsInCollisionError =
            "Time interval is in collision with another's fishing record time interval!";

        public PresenterFishingRecord(IViewFishingRecord inView)
        {
            _view = inView;

            // fill view with data
            _view.Locations = LocationRepository.GetInstance().GetLocationNames();
            _view.Winds = CommonPresenterStuff.GetWindStrings();
            _view.MoonPhases = CommonPresenterStuff.GetMoonPhaseStrings();
            _view.Tides = CommonPresenterStuff.GetTideStrings();
        }

        public void AddFishCatchRequest()
        {
            _view.ChangeToFishCatchAddView();
        }

        public void AddFishSaleRequest()
        {
            _view.ChangeToFishSaleAddView();
        }

        public void DeleteFishCatchRequest(string inFish)
        {
            _view.DeleteFishCatch(inFish);
            if (_fishCatch.GetSoldFish().Contains(inFish))
            {
                _view.DeleteFishSale(inFish);
            }

            _fishCatch.DeleteCatch(inFish);
        }

        public void DeleteFishSaleRequest(string inFish)
        {
            _fishCatch.DeleteSale(inFish);
            _view.DeleteFishSale(inFish);
        }

        public void Update(Object inObject)
        {
            if (inObject is object[])
            {
                var param = inObject as object[];
                if (param.Length == 2)
                {
                    AddFishCatch((string)param[0], (double)param[1]);
                }
                else if (param.Length == 3)
                {
                    AddFishSale((string)param[0], (double)param[1], (double)param[2]);
                }
            }
        }

        public void FinishRequest()
        {
            FishingRecord record;

            // validate fields
            try
            {
                // date and time
                CommonPresenterStuff.ValidateDateEarlierThanNow(_view.DateTimeStart, "start date and time");
                CommonPresenterStuff.ValidateCronologicalDates(_view.DateTimeStart, _view.DateTimeEnd,
                    "start date and time", "end date and time");

                // location name
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Location, "location");

                // nature events
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Wind, "wind");
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.MoonPhase, "moon phase");
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Tide, "tide");
            }
            catch (Exception e)
            {
                _view.ShowErrorMessage(e.Message);
                return;
            }
            
            // if fish catch or sale is empty, warn user
            if (_fishCatch.GetCaughtFish().Count == 0)
            {
                if (!_view.WarnUser(CommonPresenterStuff.WarnFieldEmptyMessage("fish catch")))
                {
                    return;
                }
            }
            if (_fishCatch.GetSoldFish().Count == 0)
            {
                if (!_view.WarnUser(CommonPresenterStuff.WarnFieldEmptyMessage("fish sale")))
                {
                    return;
                }
            }

            // try create record
            Winds wind = CommonPresenterStuff.GetWindEnum(_view.Wind);
            MoonPhases moonPhase = CommonPresenterStuff.GetMoonPhaseEnum(_view.MoonPhase);
            Tides tide = CommonPresenterStuff.GetTideEnum(_view.Tide);

            try
            {
                record = FishingRecordFactory.CreateFishingRecord(_view.DateTimeStart, _view.DateTimeEnd,
                    _view.Location, wind, moonPhase, tide, _fishCatch);
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
                return;
            }

            Finish(record);
        }

        public void CancelRequest()
        {
            _view.End();
        }

        private void AddFishCatch(string inFish, double inMass)
        {
            _fishCatch.AddCatch(inFish, inMass);
            _view.AddFishCatch(inFish, inMass);
        }

        private void AddFishSale(string inFish, double inMass, double inPrice)
        {
            _fishCatch.AddSale(inFish, inMass, inPrice);
            _view.AddFishSale(inFish, inMass, inPrice);
        }

        public abstract void Finish(FishingRecord record);
    }
}
