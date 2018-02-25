using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterLocationEdit : PresenterLocation
    {
        private int _locationIndex;

        public PresenterLocationEdit(IViewLocation inView, int inLocationIndex) : base(inView)
        {
            _locationIndex = inLocationIndex;
            Location location = LocationRepository.GetInstance().GetLocation(inLocationIndex);

            // set location details on view
            _view.LocationName = location.Name;
            _view.Latitude = location.Coordinates.Latitude.ToString();
            _view.Longitude = location.Coordinates.Longitude.ToString();
            _view.Depth = location.Depth.ToString();
            _view.Comment = location.Comment;

            _view.SetFinishButtonText("Save changes");
        }

        public override void Finish(Location location)
        {
            // try updating location
            try
            {
                LocationRepository.GetInstance().UpdateLocation(_locationIndex, location);
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

            _view.ShowMessage("Changes saved.");
            _view.End();
        }
    }
}
