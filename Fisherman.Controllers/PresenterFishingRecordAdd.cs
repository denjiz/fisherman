using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterFishingRecordAdd : PresenterFishingRecord
    {
        public PresenterFishingRecordAdd(IViewFishingRecord inView) : base(inView)
        {
            _fishCatch = new FishCatch();
        }

        public override void Finish(FishingRecord record)
        {
            // try adding record
            try
            {
                FishingRecordRepository.GetInstance().AddRecord(record);
            }
            catch (FishingRecordAlreadyExistsException)
            {
                _view.ShowErrorMessage("Fishing record already exists!");
                return;
            }
            catch (FishingRecordsInCollisionException)
            {
                _view.ShowErrorMessage(_fishingRecordsInCollisionError);
                return;
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
                return;
            }

            NotifyObservers(new Object());

            _view.ShowMessage("Fishing record added.");
            _view.End();
        }
    }
}
