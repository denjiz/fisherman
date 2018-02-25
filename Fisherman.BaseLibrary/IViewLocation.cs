using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IViewLocation : IView
    {
        string LocationName { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
        string Depth { get; set; }
        string Comment { get; set; }

        void SetFinishButtonText(string text);
    }
}
