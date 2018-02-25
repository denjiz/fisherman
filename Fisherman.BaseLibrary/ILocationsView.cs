using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.BaseLibrary
{
    public interface ILocationsView
    {
        void ShowLocations(List<Location> locations);

        void ChangeToEditLocationView(int index);

        void ChangeToAddLocationView();
    }
}
