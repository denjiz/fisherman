using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fisherman.BaseLibrary
{
    public interface IViewLocations : IView
    {
        void AddLocation(string name, double latitude, double longitude, double depth, string comment);
        void UpdateLocation(string name, double latitude, double longitude, double depth, string comment);
        void DeleteLocation(int index);
        void DeleteLocations();
        bool ContainsLocation(string name);

        void ChangeToLocationAddView();
        void ChangeToLocationEditView(int index);
    }
}
