using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public abstract class PresenterLocation : Subject
    {
        protected readonly IViewLocation _view;
        protected const string _locationError = "Location with same name or coordinates already exists!";

        public PresenterLocation(IViewLocation inView)
        {
            _view = inView;
        }

        public void FinishRequest(string inName, string inLatitude, string inLongitude, string inDepth, string inComment)
        {
            Location location;
            double latitude, longitude, depth;

            // validate fields
            try
            {
                // location name
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.LocationName, "name");

                // latitude
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Latitude, "latitude");
                latitude = CommonPresenterStuff.ValidateDoubleString(_view.Latitude, "latitude");
                CommonPresenterStuff.ValidateDoubleInRange(latitude, -90.0, 90.0, "latitude");

                // longitude
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Longitude, "longitude");
                longitude = CommonPresenterStuff.ValidateDoubleString(_view.Longitude, "longitude");
                CommonPresenterStuff.ValidateDoubleInRange(longitude, -180.0, 180.0, "longitude");

                // depth
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Depth, "depth");
                depth = CommonPresenterStuff.ValidateDoubleString(_view.Depth, "depth");
                CommonPresenterStuff.ValidateDoubleGreaterThan(depth, 0.0, "depth");
            }
            catch (Exception e)
            {
                _view.ShowErrorMessage(e.Message);
                return;
            }

            // if comment is empty, warn user
            if (_view.Comment == "")
            {
                if (!_view.WarnUser(CommonPresenterStuff.WarnFieldEmptyMessage("comment")))
                {
                    return;
                }
            }

            // try creating location
            try
            {
                location = LocationFactory.CreateLocation(inName, latitude, longitude, depth, inComment);
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
                return;
            }

            Finish(location);
        }

        public abstract void Finish(Location location);
    }
}
