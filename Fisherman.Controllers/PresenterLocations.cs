using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterLocations : IFishermanObserver
    {
        private readonly IViewLocations _view;

        public PresenterLocations(IViewLocations inView)
        {
            _view = inView;

            // load locations
            LocationRepository repository = LocationRepository.GetInstance();
            ShowLocations(repository.GetLocations());

            // attach self to repository
            repository.Attach(this);
        }

        public void AddLocationRequest()
        {
            _view.ChangeToLocationAddView();
        }

        public void EditLocationRequest(int index)
        {
            _view.ChangeToLocationEditView(index);
        }

        public void DeleteLocationRequest(int inLocationIndex)
        {
            // warn user
            if (_view.WarnUser(CommonPresenterStuff.WarnDeleteMessage("location")))
            {
                // try deleting location
                try
                {
                    LocationRepository.GetInstance().DeleteLocation(inLocationIndex);
                }
                catch (LocationPartOfFishingRecordException)
                {
                    _view.ShowErrorMessage("Location can't be deleted!\nIt is a part of one or more fishing records.");
                    return;
                }
                catch (Exception)
                {
                    _view.ShowErrorMessage(CommonPresenterStuff.ErrorMessage());
                    return;
                }
            }
        }

        public void CloseRequest()
        {
            _view.End();
        }

        public void Update(object inObject)
        {
            ShowLocations(LocationRepository.GetInstance().GetLocations());
        }

        private void ShowLocations(List<Location> locations)
        {
            _view.DeleteLocations();
            foreach (Location location in locations)
            {
                _view.AddLocation(location.Name, location.Coordinates.Latitude, location.Coordinates.Longitude, location.Depth, location.Comment);
            }
        }
    }
}
