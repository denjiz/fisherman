using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable]
    public abstract class FishermanBaseException : Exception { }

    [Serializable]
    public class FishingRecordAlreadyExistsException : FishermanBaseException { }

    [Serializable]
    public class FishingRecordDoesntExistException : FishermanBaseException { }

    [Serializable]
    public class FishingRecordsInCollisionException : FishermanBaseException { }

    [Serializable]
    public class LocationAlreadyExistsException : FishermanBaseException { }

    [Serializable]
    public class LocationDoesntExistException : FishermanBaseException { }

    [Serializable]
    public class LocationPartOfFishingRecordException : FishermanBaseException { }

    [Serializable]
    public class FishCatchAlreadyExistsException : FishermanBaseException { }

    [Serializable]
    public class FishNotCaughtException : FishermanBaseException { }

    [Serializable]
    public class FishSaleAlreadyAddedException : FishermanBaseException { }

    [Serializable]
    public class SaleMassGreaterThanCaughtMassException : FishermanBaseException { }
}
