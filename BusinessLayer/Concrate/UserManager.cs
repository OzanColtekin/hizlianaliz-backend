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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(Users t)
        {
            _userDal.Add(t);
        }

        public Users TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<Users> TGetList()
        {
            return _userDal.GetList();
        }

        public void TRemove(Users t)
        {
            _userDal.Delete(t);
        }

        public void TUpdate(Users t)
        {
            _userDal.Update(t);
        }
    }
}
