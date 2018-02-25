using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fisherman.BaseLibrary
{
    public interface IController
    {
        void AddFishingRecordRequest(Form caller);
    }
}
