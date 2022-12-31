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
    public class UserAPIManager : IUserAPIService
    {
        IUserAPIDal _userAPIDal;

        public UserAPIManager(IUserAPIDal userAPIDal)
        {
            _userAPIDal = userAPIDal;
        }

        public void TAdd(UserAPIs t)
        {
            _userAPIDal.Add(t);
        }

        public UserAPIs TGetByID(int id)
        {
            return _userAPIDal.GetByID(id);
        }

        public List<UserAPIs> TGetList()
        {
            return _userAPIDal.GetList();
        }

        public void TRemove(UserAPIs t)
        {
            _userAPIDal.Delete(t);
        }

        public void TUpdate(UserAPIs t)
        {
            _userAPIDal.Update(t);
        }
    }
}
