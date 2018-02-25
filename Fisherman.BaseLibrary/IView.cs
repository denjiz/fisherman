using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IView
    {
        void ShowMessage(string text);
        bool WarnUser(string text);
        void ShowErrorMessage(string text);
        void End();
    }
}
