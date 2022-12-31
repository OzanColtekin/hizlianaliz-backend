using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class UserProductManager : IUserProductsService
    {
        IUserProductDal _userProductDal;

        public UserProductManager(IUserProductDal userProductDal)
        {
            _userProductDal = userProductDal;
        }

        public void TAdd(UserProducts t)
        {
            _userProductDal.Add(t);
        }

        public UserProducts TGetByID(int id)
        {
            return _userProductDal.GetByID(id);
        }

        public List<UserProducts> TGetList()
        {
            return _userProductDal.GetList();
        }

        public void TRemove(UserProducts t)
        {
            _userProductDal.Delete(t);
        }

        public void TUpdate(UserProducts t)
        {
            _userProductDal.Update(t);
        }
    }
}
