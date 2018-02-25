using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IAddFishCatchView
    {
        string[] FishNames { set; }
        string FishName { get; }
        string Mass { get; }
        void ShowErrorMessage(string text);
        void End();
    }
}
