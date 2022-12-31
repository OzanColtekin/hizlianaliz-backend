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
    public class AlertManager : IAlertService
    {
        IAlertDal _alertDal;

        public AlertManager(IAlertDal alertDal)
        {
            _alertDal = alertDal;
        }

        public void TAdd(Alerts t)
        {
            _alertDal.Add(t);
        }

        public Alerts TGetByID(int id)
        {
            return _alertDal.GetByID(id);
        }

        public List<Alerts> TGetList()
        {
            return _alertDal.GetList();
        }

        public void TRemove(Alerts t)
        {
            _alertDal.Delete(t);
        }

        public void TUpdate(Alerts t)
        {
            _alertDal.Update(t);
        }
    }
}
