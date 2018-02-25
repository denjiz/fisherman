using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IViewFishingRecord : IView
    {
        string[] Locations { set; }
        string[] Winds { set; }
        string[] MoonPhases { set; }
        string[] Tides { set; }

        DateTime DateTimeStart { get; set; }
        DateTime DateTimeEnd { get; set; }
        string Location { get; set; }
        string Wind { get; set; }
        string MoonPhase { get; set; }
        string Tide { get; set; }
        void AddFishCatch(string inFish, double inMass);
        void AddFishSale(string inFish, double inMass, double inPrice);
        void DeleteFishCatch(string inFish);
        void DeleteFishSale(string inFish);

        void ChangeToFishCatchAddView();
        void ChangeToFishSaleAddView();

        void SetFinishButtonText(string text);
    }
}
