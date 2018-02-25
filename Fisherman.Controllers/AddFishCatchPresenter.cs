using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class AddFishCatchPresenter
    {
        private readonly IAddFishCatchView _view;
        private readonly AddFishingRecordPresenter _parent;
        private string _massCommaError = "Decimal comma is not allowed!\nUse decimal point instead.";
        private string _invalidMassError = "Invalid mass!\nExamples: \"4\"  \"6.12\"  \"45.54327\"";
        private string _massLessOrEqualThanZeroError = "Mass must be greater than zero!";
        private string _emptyFishNameError = "Name field must be filled!";
        private string _fishNameError = "Name has already been added!";

        public AddFishCatchPresenter(IAddFishCatchView inView, AddFishingRecordPresenter inParentPresenter)
        {
            _view = inView;
            _parent = inParentPresenter;

            // fill view with data
            _view.FishNames = SearchService.GetFishNames();
        }

        public void AddFishCatchRequest()
        {
            string fishName;
            double mass, soldMass, soldPrice;

            // validate fish name
            fishName = _view.FishName;
            if (fishName == "")
            {
                _view.ShowErrorMessage(_emptyFishNameError);
                return;
            }
            if (_parent.fishCatch.GetCaughtFish().Contains(fishName))
            {
                _view.ShowErrorMessage(_fishNameError);
                return;
            }

            // validate mass
            if (_view.Mass.Contains(","))
            {
                _view.ShowErrorMessage(_massCommaError);
                return;
            }
            try
            {
                mass = Convert.ToDouble(_view.Mass, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(_invalidMassError);
                return;
            }
            if (mass <= 0)
            {
                _view.ShowErrorMessage(_massLessOrEqualThanZeroError);
                return;
            }
            
            // validate sold mass and price...
            if (_view.SoldMass == "")
            {
                soldMass = -1;
            }
            else
            {
                soldMass = Convert.ToDouble(_view.SoldMass);
            }
            if (_view.SoldPrice == "")
            {
                soldPrice = -1;
            }
            else
            {
                soldPrice = Convert.ToDouble(_view.SoldPrice);
            }

            // add data to parent view and close current view
            _parent.AddFishCatch(fishName, mass, soldMass, soldPrice);
            _view.End();
        }

        public void CloseRequest()
        {
            _view.End();
        }
    }
}
