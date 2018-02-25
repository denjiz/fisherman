using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IAddLocationView
    {
        void ShowErrorMessage(string text);

        void End();
    }
}
