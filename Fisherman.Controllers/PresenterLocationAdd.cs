using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterLocationAdd : PresenterLocation
    {
        public PresenterLocationAdd(IViewLocation inView) : base(inView) { }

        public override void Finish(Location location)
        {
            // try adding location
            try
            {
                LocationRepository.GetInstance().AddLocation(location);
            }
            catch (LocationAlreadyExistsException)
            {
                _view.ShowErrorMessage(_locationError);
                return;
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
                return;
            }

            NotifyObservers(new Object());

            _view.ShowMessage("Location added.");
            _view.End();
        }
    }
}
