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
    public class UserProductPriceManager : IUserProductPriceService
    {
        IUserProductPriceDal _userProductPriceDal;

        public UserProductPriceManager(IUserProductPriceDal userProductPriceDal)
        {
            _userProductPriceDal = userProductPriceDal;
        }

        public void TAdd(UserProductPrices t)
        {
            _userProductPriceDal.Add(t);
        }

        public UserProductPrices TGetByID(int id)
        {
            return _userProductPriceDal.GetByID(id);    
        }

        public List<UserProductPrices> TGetList()
        {
            return _userProductPriceDal.GetList();
        }

        public void TRemove(UserProductPrices t)
        {
            _userProductPriceDal.Delete(t);
        }

        public void TUpdate(UserProductPrices t)
        {
            _userProductPriceDal.Update(t);
        }
    }
}
