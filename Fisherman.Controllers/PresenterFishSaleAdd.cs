using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterFishSaleAdd : Subject
    {
        private readonly IViewFishSale _view;

        public PresenterFishSaleAdd(IViewFishSale inView)
        {
            _view = inView;

            // fill view with data
            _view.FishNames = Search.GetFishNames();
        }

        public void AddFishSaleRequest()
        {
            double mass, price;

            // validate fields
            try
            {
                // fish name
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.FishName, "fish");

                // sold mass
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Mass, "mass");
                mass = CommonPresenterStuff.ValidateDoubleString(_view.Mass, "mass");
                CommonPresenterStuff.ValidateDoubleGreaterThan(mass, 0.0, "mass");

                // sale price
                CommonPresenterStuff.ValidateFieldNotEmpty(_view.Price, "price");
                price = CommonPresenterStuff.ValidateDoubleString(_view.Price, "price");
                CommonPresenterStuff.ValidateDoubleGreaterThan(price, 0.0, "price");
            }
            catch (Exception e)
            {
                _view.ShowErrorMessage(e.Message);
                return;
            }

            // try adding fish sale
            try
            {
                Object fishSale = new object[] {_view.FishName, mass, price};
                NotifyObservers(fishSale);
            }
            catch (FishSaleAlreadyAddedException)
            {
                _view.ShowErrorMessage("Fish sale has already been added");
                return;
            }
            catch (FishNotCaughtException)
            {
                _view.ShowErrorMessage("Fish must first be caught!");
                return;
            }
            catch (SaleMassGreaterThanCaughtMassException)
            {
                _view.ShowErrorMessage("Sale mass must be less or equal than caught mass!");
                return;
            }
            catch (Exception)
            {
                _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
            }

            _view.End();
        }

        public void CloseRequest()
        {
            _view.End();
        }
    }
}
