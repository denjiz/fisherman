using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IFishermanObserver
    {
        void Update(Object inObject);
    }
}
