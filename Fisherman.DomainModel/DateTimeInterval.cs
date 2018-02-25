using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class DateTimeInterval
    {
        private DateTime _start;
        private DateTime _end;

        public DateTimeInterval(DateTime inStart, DateTime inEnd)
        {
            Start = inStart;
            End = inEnd;
        }

        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

        internal bool IsInCollisionWith(DateTimeInterval inDtInterval)
        {
            if (((Start.CompareTo(inDtInterval.Start) <= 0) & End.CompareTo(inDtInterval.Start) >= 0) |
                ((Start.CompareTo(inDtInterval.End) <= 0) & End.CompareTo(inDtInterval.Start) >= 0))
            {
                return true;
            }

            return false;
        }
    }
}
