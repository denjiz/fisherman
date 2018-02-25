using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IAddFishingRecordView
    {
        DateTime StartDateTime { get; }
        DateTime EndDateTime { get; }
        string[] Locations { set; }
        string[] Winds { set; }
        string[] MoonPhases { set; }
        string[] Tides { set; }
        string[] FishCatch { get; }
        string Location { get; }
        string Wind { get; }
        string MoonPhase { get; }
        string Tide { get; }
        void ChangeToAddFishCatchView();
        void ShowErrorMessage(string text);
        void End();
        void ShowFishCatch(DomainModel.FishCatch fishCatch);

        void ChangeToAddSaleView();

        void ShowFishSale(DomainModel.FishCatch fishCatch);

        void ShowRecord(DomainModel.FishingRecord record);

        void SetFinishButtonText(string p);
    }
}
