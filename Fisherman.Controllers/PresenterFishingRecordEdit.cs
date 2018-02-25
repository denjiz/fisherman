using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterFishingRecordEdit : PresenterFishingRecord
    {
        private int _recordIndex;

        public PresenterFishingRecordEdit(IViewFishingRecord inView, int inRecordIndex) : base(inView)
        {
            _recordIndex = inRecordIndex;
            FishingRecord record = FishingRecordRepository.GetInstance().GetRecord(inRecordIndex);
            _fishCatch = record.FishCatch;

            // set record details on view
            _view.DateTimeStart = record.DateTimeInterval.Start;
            _view.DateTimeEnd = record.DateTimeInterval.End;
            _view.Location = record.Location.Name;
            _view.Wind = CommonPresenterStuff.GetWindStrings()[(int)record.NatureContex.Wind];
            _view.MoonPhase = CommonPresenterStuff.GetMoonPhaseStrings()[(int)record.NatureContex.MoonPhase];
            _view.Tide = CommonPresenterStuff.GetTideStrings()[(int)record.NatureContex.Tide];
            foreach (string fish in record.FishCatch.GetCaughtFish())
            {
                _view.AddFishCatch(fish, record.FishCatch.GetCaughtFishMass(fish));
            }
            foreach (string fish in record.FishCatch.GetSoldFish())
            {
                _view.AddFishSale(fish, record.FishCatch.GetSoldFishMass(fish), record.FishCatch.GetSoldFishPrice(fish));
            }

            _view.SetFinishButtonText("Save changes");
        }

        public override void Finish(FishingRecord record)
        {
            // try updating records
            try
            {
                FishingRecordRepository.GetInstance().UpdateRecord(_recordIndex, record);
            }
            catch (FishingRecordsInCollisionException)
            {
                _view.ShowErrorMessage(_fishingRecordsInCollisionError);
                return;
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
            }

            NotifyObservers(new Object());

            _view.ShowMessage("Changes saved.");
            _view.End();
        }
    }
}
