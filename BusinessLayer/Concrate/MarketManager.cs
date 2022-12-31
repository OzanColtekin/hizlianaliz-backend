using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class MarketManager : IMarketService
    {
        IMarketDal _marketDal;

        public MarketManager(IMarketDal marketDal)
        {
            _marketDal = marketDal;
        }

        public void TAdd(Markets t)
        {
            _marketDal.Add(t);
        }

        public Markets TGetByID(int id)
        {
            return _marketDal.GetByID(id);
        }

        public List<Markets> TGetList()
        {
            return _marketDal.GetList();
        }

        public void TRemove(Markets t)
        {
            _marketDal.Delete(t);
        }

        public void TUpdate(Markets t)
        {
            _marketDal.Update(t);
        }
    }
}
