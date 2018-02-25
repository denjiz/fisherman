using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IViewFishSale : IView
    {
        string[] FishNames { set; }

        string FishName { get; set; }
        string Mass { get; set; }
        string Price { get; set; }
    }
}
