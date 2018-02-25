using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterFishCatchAdd : Subject
    {
        private readonly IViewAddFishCatch _view;

        public PresenterFishCatchAdd(IViewAddFishCatch inView)
        {
            _view = inView;

            // fill view with data
            _view.FishNames = Search.GetFishNames();
        }

        public void AddFishCatchRequest()
        {
            double mass;

            // validate fields
            try
            {
                // fish name
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.FishName, "fish");

                // caught mass
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Mass, "mass");
                mass = CommonPresenterStuff.ValidateDoubleString(_view.Mass, "mass");
                CommonPresenterStuff.ValidateDoubleGreaterThan(mass, 0.0, "mass");
            }
            catch (Exception e)
            {
                _view.ShowErrorMessage(e.Message);
                return;
            }

            // try adding fish catch
            try
            {
                object[] fishCatch = {_view.FishName, mass};
                NotifyObservers(fishCatch);
            }
            catch (FishCatchAlreadyExistsException)
            {
                _view.ShowErrorMessage("Fish has already been caught!");
                return;
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
                return;
            }

            _view.End();
        }

        public void CloseRequest()
        {
            _view.End();
        }
    }
}
