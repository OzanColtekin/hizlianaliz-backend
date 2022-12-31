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
    public class ProductRankManager : IProductRankService
    {
        IProductRankDal _productRankDal;

        public ProductRankManager(IProductRankDal productRankDal
            )
        {
            _productRankDal = productRankDal;
        }

        public void TAdd(ProductRanks t)
        {
            _productRankDal.Add(t);
        }

        public ProductRanks TGetByID(int id)
        {
            return _productRankDal.GetByID(id);
        }

        public List<ProductRanks> TGetList()
        {
            return _productRankDal.GetList();
        }

        public void TRemove(ProductRanks t)
        {
            _productRankDal.Delete(t);
        }

        public void TUpdate(ProductRanks t)
        {
            _productRankDal.Update(t);
        }
    }
}
