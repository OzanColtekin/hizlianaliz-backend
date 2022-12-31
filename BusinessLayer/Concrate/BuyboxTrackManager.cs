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
    public class BuyboxTrackManager : IBuyboxTrackService
    {
        IBuyboxTrackDal _buyboxTrackDal;

        public BuyboxTrackManager(IBuyboxTrackDal buyboxTrackDal)
        {
            _buyboxTrackDal = buyboxTrackDal;
        }

        public void TAdd(BuyboxTrack t)
        {
            _buyboxTrackDal.Add(t);
        }

        public BuyboxTrack TGetByID(int id)
        {
            return _buyboxTrackDal.GetByID(id);
        }

        public List<BuyboxTrack> TGetList()
        {
            return _buyboxTrackDal.GetList();
        }

        public void TRemove(BuyboxTrack t)
        {
            _buyboxTrackDal.Delete(t);
        }

        public void TUpdate(BuyboxTrack t)
        {
            _buyboxTrackDal.Update(t);
        }
    }
}
