using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class FishCatch
    {
        private Dictionary<string, double> _catchDict;
        private Dictionary<string, FishSaleInfo> _saleDict;

        public FishCatch()
        {
            CatchDict = new Dictionary<string, double>();
            SaleDict = new Dictionary<string, FishSaleInfo>();
        }

        public void AddCatch(string inFishName, double inMass)
        {
            if (CatchDict.ContainsKey(inFishName))
            {
                throw new FishCatchAlreadyExistsException();
            }

            CatchDict.Add(inFishName, inMass);
        }

        private Dictionary<string, double> CatchDict
        {
            get { return _catchDict; }
            set { _catchDict = value; }
        }

        private Dictionary<string, FishSaleInfo> SaleDict
        {
            get { return _saleDict; }
            set { _saleDict = value; }
        }

        public void AddSale(string inFishName, double inSaleMass, double inSalePrice)
        {
            if (SaleDict.ContainsKey(inFishName))
            {
                throw new FishSaleAlreadyAddedException();
            }

            if (!_catchDict.ContainsKey(inFishName))
            {
                throw new FishNotCaughtException();
            }

            if (_catchDict[inFishName] < inSaleMass)
            {
                throw new SaleMassGreaterThanCaughtMassException();
            }

            FishSaleInfo info = new FishSaleInfo(inSaleMass, inSalePrice);
            SaleDict.Add(inFishName, info);
        }

        public List<string> GetCaughtFish()
        {
            return _catchDict.Keys.ToList();
        }

        public double GetCaughtFishMass(string inFish)
        {
            return _catchDict[inFish];
        }

        public List<string> GetSoldFish()
        {
            return _saleDict.Keys.ToList();
        }

        public double GetSoldFishPrice(string inFish)
        {
            return _saleDict[inFish].Price;
        }

        public double GetSoldFishMass(string inFish)
        {
            return _saleDict[inFish].Mass;
        }

        public void DeleteCatch(string inFish)
        {
            _catchDict.Remove(inFish);
            _saleDict.Remove(inFish);
        }

        public void DeleteSale(string inFish)
        {
            _saleDict.Remove(inFish);
        }
    }
}
